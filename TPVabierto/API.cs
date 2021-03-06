﻿///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.WindowsAPICodePack.Shell;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;

namespace TPVabierto
{
    class API
    {
        public static string[] StringToArray(string input)
        {
            //string[] stringList = input.Split(separator.ToCharArray(),
            //                                  StringSplitOptions.RemoveEmptyEntries);
            //object[] list = new object[stringList.Length];

            //for (int i = 0; i < stringList.Length; i++)
            //{
            //    list[i] = Convert.ChangeType(stringList[i], type);
            //}

            //return list;

            return new string[] { input };
        }

        public static string ArrayToStringEnNuevaLinea(string[] arrayaconvertir)
        {
            return string.Join(Environment.NewLine, arrayaconvertir);
        }

        public static void CrearArchivo(string nombredearchivo)
        {
            File.WriteAllText(nombredearchivo, string.Empty);
        }
        public static void AgregarAArchivo(string texto, string archivo)
        {
            if (File.ReadAllText(archivo) == string.Empty) File.AppendAllText(archivo, texto);
            else File.AppendAllText(archivo, Environment.NewLine + texto);

        }

        public static string LeerLineaEspecificaArchivo(string archivo, int numlinea)
        {
            using (var sr = new StreamReader(archivo))
            {
                for (int i = 1; i < numlinea; i++)
                    sr.ReadLine();
                return sr.ReadLine().ToString();
            }
        }

        public static void EliminarLinea(string linea, string archivo)
        {
            string strSearchText = linea;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(archivo);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(archivo, n);
        }

        public static void QuitarLineasVacias(string archivo)
        {
            var lines = File.ReadAllLines(archivo).Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(archivo, lines);
        }

        public static string SepararTexto(string frase)
        {
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(frase);
            string alphaPart = result.Groups[1].Value;
            string numberPart = result.Groups[2].Value;

            return alphaPart;
        }

        public static string SepararNumero(string frase)
        {
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(frase);
            string alphaPart = result.Groups[1].Value;
            string numberPart = result.Groups[2].Value;

            return numberPart;
        }

        public static string[] LeerTodoStringMultiple(string archivo)
        {
            string[] lines = File.ReadAllLines(archivo);
            return lines;
        }

        public static string LeerTodoString(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            string usuarios = string.Join(Environment.NewLine, lineas);
            API.QuitarLineasVacias(archivo);
            return usuarios;
        }

        public static int TotalLineas(string archivo)
        {
            var lineCount = File.ReadLines(archivo).Count();
            return lineCount;
        }

        public static bool ComprobarSiHayLetras(string linea)
        {
            return Regex.IsMatch(linea, @"^[a-zA-Z]+$");
        }

        public static string[] ComasAString(string lineaconcomas)
        {
            return lineaconcomas.Split(',');
        }

        public static string LimpiarString(string stringconlineasvacias)
        {

           return Regex.Replace(stringconlineasvacias, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
            
        }


        public static void Comandodb(string comando)
        {
            
            try
            {
                SQLiteConnection conn = new SQLiteConnection(("Data Source=Datos.sqlite;Version=3;"));
                conn.Open();
                SQLiteCommand c = new SQLiteCommand(comando, conn);
                c.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TPVabierto - Error SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static string ComandodbConSalida(string comando)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(("Data Source=Datos.sqlite;Version=3;"));
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter(comando, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return API.convertirDTaString(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TPVabierto - Error SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "TPVabierto - Error SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
                

        }

        public static bool BuscarenDB(string tabla, string columna, string texto)
        {
            // Buscar en la base de datos haber si está
            SQLiteConnection conn = new SQLiteConnection(("Data Source=Datos.sqlite;Version=3;"));
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from " + tabla + " where " + columna + " like '" + texto + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            // Ver si la tabla está vacia, si lo está pues no ha encontrado nada
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            // Esta siguente linea nunca se ejecutara
            return false;
        }

        public static int TotalLineasDB(string tabla)
        { 
            
                SQLiteConnection conn = new SQLiteConnection(("Data Source=Datos.sqlite;Version=3;"));
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Count(*) FROM " + tabla, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return int.Parse(API.convertirDTaString(dt));
        }

        public static string DeXsacaYdb(string Tabla, string columnaquetienes,string valorquetienes, string loquequieres)
        {
            SQLiteConnection conn = new SQLiteConnection(("Data Source=Datos.sqlite;Version=3;"));
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT " + loquequieres + " FROM " + Tabla + " WHERE " + columnaquetienes +" = '" + valorquetienes + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return API.convertirDTaString(dt);
        }

        public static string DeXsacaYdbNUM(string Tabla, string columnaquetienes, long valorquetienes, string loquequieres)
        {
            SQLiteConnection conn = new SQLiteConnection(("Data Source=Datos.sqlite;Version=3;"));
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT " + loquequieres + " FROM " + Tabla + " WHERE " + columnaquetienes +" = '" + valorquetienes + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return API.convertirDTaString(dt);
        }

        public static string convertirDTaString(DataTable dt)
        {
            string datos = string.Empty;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    datos += row[j];
                    if (j == dt.Columns.Count - 1)
                    {
                        if (i != (dt.Rows.Count - 1))
                            datos += "$";
                    }
                    else
                        datos += "|";
                }
            }
            return datos;
        }

    }
}
