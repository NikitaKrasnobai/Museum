using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;
using PUSHKA.MySQL;

public class AutorizeScripts : MonoBehaviour
{

    public TMP_InputField LoginField;

    public TMP_InputField PasswordField;

    MySqlConnection SqlConnection;

    MySqlCommand SqlCommand;

    MySqlDataReader MS_Reader;

    readonly string connString = "Server= 152.67.67.162" + ";Database=" + "DB" + ";User =" + "DB" + ";Password=" + "Q1w2E3r4!" + "; charset = utf8;";

    readonly string command = "Select * FROM users";

    private void OnMouseDown()
    {
        SqlDataBase sqlDataBase = new SqlDataBase("152.67.67.162", "DB", "DB", "Q1w2E3r4!");
        sqlDataBase.RunQuery("Select * FROM users");
        try
        {
            SqlConnection = new MySqlConnection(connString);
            SqlConnection.Open();
            Debug.Log(SqlConnection.State);
       

        SqlCommand = new MySqlCommand(command, SqlConnection);

        MySqlDataReader MS_Reader = SqlCommand.ExecuteReader();

        if (SqlCommand != null)
        {
            if (MS_Reader != null)
            {
                while (MS_Reader.Read())
                {
                    try
                    {
                        if (LoginField.text.ToString() == MS_Reader[2].ToString())
                        {
                            if (PasswordField.text.ToString() == MS_Reader[4].ToString())
                            {
                                SceneManager.LoadScene(1);
                            }

                            Debug.Log("Авторизованы в аккаунт" + MS_Reader[4].ToString());
                        }
                    }
                    catch { }
                }
            }
        }
        }
        catch (Exception) { Debug.Log(SqlConnection.State); }

        try { SqlConnection.Close(); }

        catch (Exception) { Debug.Log(SqlConnection.State); }

    }
}
