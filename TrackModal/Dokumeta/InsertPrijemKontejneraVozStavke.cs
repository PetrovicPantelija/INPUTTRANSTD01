﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TrackModal.Dokumeta
{
    class InsertPrijemKontejneraVozStavke
    {

        public void InsertPrijemKontVozStavke( int IdNadredjenog, string BrojKontejnera, String BrojVagona, double Granica, double BrojOsovina, double SopstvenaMasa , double Tara, double Neto, int Posiljalac,int Primalac,int VlasnikKontejnera, int TipKontejnera, 	int VrstaRobe,int Buking, int StatusKontejnera,string BrojPlombe,int PlaniraniLager, int IdVoza, DateTime VremeDolaska, 	DateTime VremePripremljen, 	DateTime VremeOdlaska,	DateTime Datum, string Korisnik, string BrojPlombe2, int Organizator, string BukingBrodar, string NapomenaS)
        {
            /*
			@IDNadredjenog int
         
           ,@BrojKontejnera int
		   ,@BrojVagona decimal(18,2)
           ,@Granica decimal(18,2)
           ,@BrojOsovina decimal(18,2)
           ,@SopstvenaMasa decimal(18,2)
           ,@Tara decimal(18,2)
           ,@Neto decimal(18,2)
           ,@Posiljalac int
           ,@Primalac int
           ,@VlasnikKontejnera int
           ,@TipKontejnera int
           ,@VrstaRobe int
           ,@Buking int
           ,@StatusKontejnera int
           ,@BrojPlombe nvarchar(30)
           ,@PlaniraniLager int
           ,@IdVoza int
           ,@VremeDolaska datetime
           ,@VremePripremljen datetime
           ,@VremeOdlaska datetime
           ,@Datum datetime
           ,@Korisnik nvarchar(20))
            */

            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(s_connection);
            SqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "InsertPrijemKontejneraVozStavke";
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@IdNadredjenog";
            parameter1.SqlDbType = SqlDbType.Int;
       
            parameter1.Direction = ParameterDirection.Input;
            parameter1.Value = IdNadredjenog;
            myCommand.Parameters.Add(parameter1);

           

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@BrojKontejnera";
            parameter2.SqlDbType = SqlDbType.NVarChar;
            parameter2.Size = 20;
            parameter2.Direction = ParameterDirection.Input;
            parameter2.Value = BrojKontejnera;
            myCommand.Parameters.Add(parameter2);

            SqlParameter parameter3 = new SqlParameter();
            parameter3.ParameterName = "@BrojVagona";
            parameter3.SqlDbType = SqlDbType.NVarChar;
            parameter3.Size = 20;
            parameter3.Direction = ParameterDirection.Input;
            parameter3.Value = BrojVagona;
            myCommand.Parameters.Add(parameter3);


            SqlParameter parameter4 = new SqlParameter();
            parameter4.ParameterName = "@Granica";
            parameter4.SqlDbType = SqlDbType.Decimal;
           // parameter4.Size = 20;
            parameter4.Direction = ParameterDirection.Input;
            parameter4.Value = Granica;
            myCommand.Parameters.Add(parameter4);
           
            SqlParameter parameter5 = new SqlParameter();
            parameter5.ParameterName = "@BrojOsovina";
            parameter5.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter5.Direction = ParameterDirection.Input;
            parameter5.Value = BrojOsovina;
            myCommand.Parameters.Add(parameter5);

            SqlParameter parameter6 = new SqlParameter();
            parameter6.ParameterName = "@SopstvenaMasa";
            parameter6.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter6.Direction = ParameterDirection.Input;
            parameter6.Value = SopstvenaMasa;
            myCommand.Parameters.Add(parameter6);

            SqlParameter parameter7 = new SqlParameter();
            parameter7.ParameterName = "@Tara";
            parameter7.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter7.Direction = ParameterDirection.Input;
            parameter7.Value = Tara;
            myCommand.Parameters.Add(parameter7);

            SqlParameter parameter8 = new SqlParameter();
            parameter8.ParameterName = "@Neto";
            parameter8.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter8.Direction = ParameterDirection.Input;
            parameter8.Value = Neto;
            myCommand.Parameters.Add(parameter8);

            SqlParameter parameter9 = new SqlParameter();
            parameter9.ParameterName = "@Posiljalac";
            parameter9.SqlDbType = SqlDbType.Int;
            parameter9.Direction = ParameterDirection.Input;
            parameter9.Value = Posiljalac;
            myCommand.Parameters.Add(parameter9);

            SqlParameter parameter10 = new SqlParameter();
            parameter10.ParameterName = "@Primalac";
            parameter10.SqlDbType = SqlDbType.Int;
            parameter10.Direction = ParameterDirection.Input;
            parameter10.Value = Primalac;
            myCommand.Parameters.Add(parameter10);

            SqlParameter parameter11 = new SqlParameter();
            parameter11.ParameterName = "@VlasnikKontejnera";
            parameter11.SqlDbType = SqlDbType.Int;
            parameter11.Direction = ParameterDirection.Input;
            parameter11.Value = VlasnikKontejnera;
            myCommand.Parameters.Add(parameter11);

            SqlParameter parameter12 = new SqlParameter();
            parameter12.ParameterName = "@TipKontejnera";
            parameter12.SqlDbType = SqlDbType.Int;
            parameter12.Direction = ParameterDirection.Input;
            parameter12.Value = TipKontejnera;
            myCommand.Parameters.Add(parameter12);

            SqlParameter parameter13 = new SqlParameter();
            parameter13.ParameterName = "@VrstaRobe";
            parameter13.SqlDbType = SqlDbType.Int;
            parameter13.Direction = ParameterDirection.Input;
            parameter13.Value = VrstaRobe;
            myCommand.Parameters.Add(parameter13);

            SqlParameter parameter14 = new SqlParameter();
            parameter14.ParameterName = "@Buking";
            parameter14.SqlDbType = SqlDbType.Int;
            parameter14.Direction = ParameterDirection.Input;
            parameter14.Value = Buking;
            myCommand.Parameters.Add(parameter14);

            SqlParameter parameter15 = new SqlParameter();
            parameter15.ParameterName = "@StatusKontejnera";
            parameter15.SqlDbType = SqlDbType.Int;
            parameter15.Direction = ParameterDirection.Input;
            parameter15.Value = StatusKontejnera;
            myCommand.Parameters.Add(parameter15);

            SqlParameter parameter16 = new SqlParameter();
            parameter16.ParameterName = "@BrojPlombe";
            parameter16.SqlDbType = SqlDbType.NVarChar;
            parameter16.Size = 30;
            parameter16.Direction = ParameterDirection.Input;
            parameter16.Value = BrojPlombe;
            myCommand.Parameters.Add(parameter16);

            SqlParameter parameter17 = new SqlParameter();
            parameter17.ParameterName = "@PlaniraniLager";
            parameter17.SqlDbType = SqlDbType.Int;
           // parameter13.Size = 30;
            parameter17.Direction = ParameterDirection.Input;
            parameter17.Value = PlaniraniLager;
            myCommand.Parameters.Add(parameter17);

            SqlParameter parameter18 = new SqlParameter();
            parameter18.ParameterName = "@IdVoza";
            parameter18.SqlDbType = SqlDbType.Int;
            // parameter13.Size = 30;
            parameter18.Direction = ParameterDirection.Input;
            parameter18.Value = IdVoza;
            myCommand.Parameters.Add(parameter18);

            SqlParameter parameter19 = new SqlParameter();
            parameter19.ParameterName = "@VremeDolaska";
            parameter19.SqlDbType = SqlDbType.DateTime;
            // parameter13.Size = 30;
            parameter19.Direction = ParameterDirection.Input;
            parameter19.Value = VremeDolaska;
            myCommand.Parameters.Add(parameter19);

            SqlParameter parameter20 = new SqlParameter();
            parameter20.ParameterName = "@VremePripremljen";
            parameter20.SqlDbType = SqlDbType.DateTime;
            // parameter13.Size = 30;
            parameter20.Direction = ParameterDirection.Input;
            parameter20.Value = VremePripremljen;
            myCommand.Parameters.Add(parameter20);

            SqlParameter parameter21 = new SqlParameter();
            parameter21.ParameterName = "@VremeOdlaska";
            parameter21.SqlDbType = SqlDbType.DateTime;
            // parameter13.Size = 30;
            parameter21.Direction = ParameterDirection.Input;
            parameter21.Value = VremeOdlaska;
            myCommand.Parameters.Add(parameter21);

            SqlParameter parameter22 = new SqlParameter();
            parameter22.ParameterName = "@Datum";
            parameter22.SqlDbType = SqlDbType.DateTime;
           // parameter22.Size = 20;
            parameter22.Direction = ParameterDirection.Input;
            parameter22.Value = Datum;
            myCommand.Parameters.Add(parameter22);
            
            SqlParameter parameter23 = new SqlParameter();
            parameter23.ParameterName = "@Korisnik";
            parameter23.SqlDbType = SqlDbType.NVarChar;
            parameter23.Size = 20;
            parameter23.Direction = ParameterDirection.Input;
            parameter23.Value = Korisnik;
            myCommand.Parameters.Add(parameter23);

            SqlParameter parameter24 = new SqlParameter();
            parameter24.ParameterName = "@BrojPlombe2";
            parameter24.SqlDbType = SqlDbType.NVarChar;
            parameter24.Size = 30;
            parameter24.Direction = ParameterDirection.Input;
            parameter24.Value = BrojPlombe2;
            myCommand.Parameters.Add(parameter24);

            SqlParameter parameter25 = new SqlParameter();
            parameter25.ParameterName = "@Organizator";
            parameter25.SqlDbType = SqlDbType.Int;
            parameter25.Direction = ParameterDirection.Input;
            parameter25.Value = Organizator;
            myCommand.Parameters.Add(parameter25);

            SqlParameter parameter26 = new SqlParameter();
            parameter26.ParameterName = "@BukingBrodar";
            parameter26.SqlDbType = SqlDbType.NVarChar;
            parameter26.Size = 20;
            parameter26.Direction = ParameterDirection.Input;
            parameter26.Value = BukingBrodar;
            myCommand.Parameters.Add(parameter26);


            SqlParameter parameter27 = new SqlParameter();
            parameter27.ParameterName = "@NapomenaS";
            parameter27.SqlDbType = SqlDbType.NVarChar;
            parameter27.Size = 100;
            parameter27.Direction = ParameterDirection.Input;
            parameter27.Value = NapomenaS;
            myCommand.Parameters.Add(parameter27);

            myConnection.Open();
            SqlTransaction myTransaction = myConnection.BeginTransaction();
            myCommand.Transaction = myTransaction;
            bool error = true;
            try
            {
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myTransaction = myConnection.BeginTransaction();
                myCommand.Transaction = myTransaction;
            }

            catch (SqlException)
            {
                throw new Exception("Neuspešan upis u bazu");
            }

            finally
            {
                if (!error)
                {
                    myTransaction.Commit();
                    MessageBox.Show("Nije uspeo upis ", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                myConnection.Close();

                if (error)
                {
                    // Nedra.DataSet1TableAdapters.QueriesTableAdapter adapter = new Nedra.DataSet1TableAdapters.QueriesTableAdapter();
                }


            }
        }

        public void UpdPrijemKontejneraVozStavke(int ID, int IdNadredjenog, string BrojKontejnera, String BrojVagona, double Granica, double BrojOsovina, double SopstvenaMasa, double Tara, double Neto, int Posiljalac, int Primalac, int VlasnikKontejnera, int TipKontejnera, int VrstaRobe, int Buking, int StatusKontejnera, string BrojPlombe, int PlaniraniLager, int IdVoza, DateTime VremeDolaska, DateTime VremePripremljen, DateTime VremeOdlaska, DateTime Datum, string Korisnik, int RB, string BrojPlombe2, int Organizator,string BukingBrodar, string NapomenaS)
        {

            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(s_connection);
            SqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "UpdatePrijemKontejneraVozStavke";
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@ID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = ID;
            myCommand.Parameters.Add(parameter);


            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@IdNadredjenog";
            parameter1.SqlDbType = SqlDbType.Int;

            parameter1.Direction = ParameterDirection.Input;
            parameter1.Value = IdNadredjenog;
            myCommand.Parameters.Add(parameter1);



            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@BrojKontejnera";
            parameter2.SqlDbType = SqlDbType.NVarChar;
            parameter2.Size = 20;
            parameter2.Direction = ParameterDirection.Input;
            parameter2.Value = BrojKontejnera;
            myCommand.Parameters.Add(parameter2);

            SqlParameter parameter3 = new SqlParameter();
            parameter3.ParameterName = "@BrojVagona";
            parameter3.SqlDbType = SqlDbType.NVarChar;
            parameter3.Size = 20;
            parameter3.Direction = ParameterDirection.Input;
            parameter3.Value = BrojVagona;
            myCommand.Parameters.Add(parameter3);


            SqlParameter parameter4 = new SqlParameter();
            parameter4.ParameterName = "@Granica";
            parameter4.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter4.Direction = ParameterDirection.Input;
            parameter4.Value = Granica;
            myCommand.Parameters.Add(parameter4);

            SqlParameter parameter5 = new SqlParameter();
            parameter5.ParameterName = "@BrojOsovina";
            parameter5.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter5.Direction = ParameterDirection.Input;
            parameter5.Value = BrojOsovina;
            myCommand.Parameters.Add(parameter5);

            SqlParameter parameter6 = new SqlParameter();
            parameter6.ParameterName = "@SopstvenaMasa";
            parameter6.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter6.Direction = ParameterDirection.Input;
            parameter6.Value = SopstvenaMasa;
            myCommand.Parameters.Add(parameter6);

            SqlParameter parameter7 = new SqlParameter();
            parameter7.ParameterName = "@Tara";
            parameter7.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter7.Direction = ParameterDirection.Input;
            parameter7.Value = Tara;
            myCommand.Parameters.Add(parameter7);

            SqlParameter parameter8 = new SqlParameter();
            parameter8.ParameterName = "@Neto";
            parameter8.SqlDbType = SqlDbType.Decimal;
            // parameter4.Size = 20;
            parameter8.Direction = ParameterDirection.Input;
            parameter8.Value = Neto;
            myCommand.Parameters.Add(parameter8);

            SqlParameter parameter9 = new SqlParameter();
            parameter9.ParameterName = "@Posiljalac";
            parameter9.SqlDbType = SqlDbType.Int;
            parameter9.Direction = ParameterDirection.Input;
            parameter9.Value = Posiljalac;
            myCommand.Parameters.Add(parameter9);

            SqlParameter parameter10 = new SqlParameter();
            parameter10.ParameterName = "@Primalac";
            parameter10.SqlDbType = SqlDbType.Int;
            parameter10.Direction = ParameterDirection.Input;
            parameter10.Value = Primalac;
            myCommand.Parameters.Add(parameter10);

            SqlParameter parameter11 = new SqlParameter();
            parameter11.ParameterName = "@VlasnikKontejnera";
            parameter11.SqlDbType = SqlDbType.Int;
            parameter11.Direction = ParameterDirection.Input;
            parameter11.Value = VlasnikKontejnera;
            myCommand.Parameters.Add(parameter11);

            SqlParameter parameter12 = new SqlParameter();
            parameter12.ParameterName = "@TipKontejnera";
            parameter12.SqlDbType = SqlDbType.Int;
            parameter12.Direction = ParameterDirection.Input;
            parameter12.Value = TipKontejnera;
            myCommand.Parameters.Add(parameter12);

            SqlParameter parameter13 = new SqlParameter();
            parameter13.ParameterName = "@VrstaRobe";
            parameter13.SqlDbType = SqlDbType.Int;
            parameter13.Direction = ParameterDirection.Input;
            parameter13.Value = VrstaRobe;
            myCommand.Parameters.Add(parameter13);

            SqlParameter parameter14 = new SqlParameter();
            parameter14.ParameterName = "@Buking";
            parameter14.SqlDbType = SqlDbType.Int;
            parameter14.Direction = ParameterDirection.Input;
            parameter14.Value = Buking;
            myCommand.Parameters.Add(parameter14);

            SqlParameter parameter15 = new SqlParameter();
            parameter15.ParameterName = "@StatusKontejnera";
            parameter15.SqlDbType = SqlDbType.Int;
            parameter15.Direction = ParameterDirection.Input;
            parameter15.Value = StatusKontejnera;
            myCommand.Parameters.Add(parameter15);

            SqlParameter parameter16 = new SqlParameter();
            parameter16.ParameterName = "@BrojPlombe";
            parameter16.SqlDbType = SqlDbType.NVarChar;
            parameter16.Size = 30;
            parameter16.Direction = ParameterDirection.Input;
            parameter16.Value = BrojPlombe;
            myCommand.Parameters.Add(parameter16);

            SqlParameter parameter17 = new SqlParameter();
            parameter17.ParameterName = "@PlaniraniLager";
            parameter17.SqlDbType = SqlDbType.Int;
            // parameter13.Size = 30;
            parameter17.Direction = ParameterDirection.Input;
            parameter17.Value = PlaniraniLager;
            myCommand.Parameters.Add(parameter17);

            SqlParameter parameter18 = new SqlParameter();
            parameter18.ParameterName = "@IdVoza";
            parameter18.SqlDbType = SqlDbType.Int;
            // parameter13.Size = 30;
            parameter18.Direction = ParameterDirection.Input;
            parameter18.Value = IdVoza;
            myCommand.Parameters.Add(parameter18);

            SqlParameter parameter19 = new SqlParameter();
            parameter19.ParameterName = "@VremeDolaska";
            parameter19.SqlDbType = SqlDbType.DateTime;
            // parameter13.Size = 30;
            parameter19.Direction = ParameterDirection.Input;
            parameter19.Value = VremeDolaska;
            myCommand.Parameters.Add(parameter19);

            SqlParameter parameter20 = new SqlParameter();
            parameter20.ParameterName = "@VremePripremljen";
            parameter20.SqlDbType = SqlDbType.DateTime;
            // parameter13.Size = 30;
            parameter20.Direction = ParameterDirection.Input;
            parameter20.Value = VremePripremljen;
            myCommand.Parameters.Add(parameter20);

            SqlParameter parameter21 = new SqlParameter();
            parameter21.ParameterName = "@VremeOdlaska";
            parameter21.SqlDbType = SqlDbType.DateTime;
            // parameter13.Size = 30;
            parameter21.Direction = ParameterDirection.Input;
            parameter21.Value = VremeOdlaska;
            myCommand.Parameters.Add(parameter21);

            SqlParameter parameter22 = new SqlParameter();
            parameter22.ParameterName = "@Datum";
            parameter22.SqlDbType = SqlDbType.DateTime;
           // parameter22.Size = 20;
            parameter22.Direction = ParameterDirection.Input;
            parameter22.Value = Datum;
            myCommand.Parameters.Add(parameter22);

            SqlParameter parameter23 = new SqlParameter();
            parameter23.ParameterName = "@Korisnik";
            parameter23.SqlDbType = SqlDbType.NVarChar;
            parameter23.Size = 20;
            parameter23.Direction = ParameterDirection.Input;
            parameter23.Value = Korisnik;
            myCommand.Parameters.Add(parameter23);
            /*
            SqlParameter parameter24 = new SqlParameter();
            parameter24.ParameterName = "@RB";
            parameter24.SqlDbType = SqlDbType.Int;
            parameter24.Direction = ParameterDirection.Input;
            parameter24.Value = RB;
            myCommand.Parameters.Add(parameter24);
            */
            SqlParameter parameter25 = new SqlParameter();
            parameter25.ParameterName = "@BrojPlombe2";
            parameter25.SqlDbType = SqlDbType.NVarChar;
            parameter25.Size = 30;
            parameter25.Direction = ParameterDirection.Input;
            parameter25.Value = BrojPlombe2;
            myCommand.Parameters.Add(parameter25);


            SqlParameter parameter26 = new SqlParameter();
            parameter26.ParameterName = "@Organizator";
            parameter26.SqlDbType = SqlDbType.Int;
            parameter26.Direction = ParameterDirection.Input;
            parameter26.Value = Organizator;
            myCommand.Parameters.Add(parameter26);

            SqlParameter parameter27 = new SqlParameter();
            parameter27.ParameterName = "@BukingBrodar";
            parameter27.SqlDbType = SqlDbType.NVarChar;
            parameter27.Size = 20;
            parameter27.Direction = ParameterDirection.Input;
            parameter27.Value = BukingBrodar;
            myCommand.Parameters.Add(parameter27);


            SqlParameter parameter28 = new SqlParameter();
            parameter28.ParameterName = "@NapomenaS";
            parameter28.SqlDbType = SqlDbType.NVarChar;
            parameter28.Size = 100;
            parameter28.Direction = ParameterDirection.Input;
            parameter28.Value = NapomenaS;
            myCommand.Parameters.Add(parameter28);

            myConnection.Open();
            SqlTransaction myTransaction = myConnection.BeginTransaction();
            myCommand.Transaction = myTransaction;
            bool error = true;
            try
            {
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myTransaction = myConnection.BeginTransaction();
                myCommand.Transaction = myTransaction;
            }

            catch (SqlException)
            {
                throw new Exception("Neuspešan upis u Bazu");
            }

            finally
            {
                if (!error)
                {
                    myTransaction.Commit();
                    MessageBox.Show("Nije uspeo upis ", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                myConnection.Close();

                if (error)
                {
                    // Nedra.DataSet1TableAdapters.QueriesTableAdapter adapter = new Nedra.DataSet1TableAdapters.QueriesTableAdapter();
                }


            }
        }

        public void DeletePrijemKontejneraVozStavke(int ID)
          {
              var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
              SqlConnection myConnection = new SqlConnection(s_connection);
              SqlCommand myCommand = myConnection.CreateCommand();
              myCommand.CommandText = "DeletePrijemKontejneraVozStavke";
              myCommand.CommandType = System.Data.CommandType.StoredProcedure;

              SqlParameter parameter = new SqlParameter();
              parameter.ParameterName = "@ID";
              parameter.SqlDbType = SqlDbType.Int;
              parameter.Direction = ParameterDirection.Input;
              parameter.Value = ID;
              myCommand.Parameters.Add(parameter);

              myConnection.Open();
              SqlTransaction myTransaction = myConnection.BeginTransaction();
              myCommand.Transaction = myTransaction;
              bool error = true;
              try
              {
                  myCommand.ExecuteNonQuery();
                  myTransaction.Commit();
                  myTransaction = myConnection.BeginTransaction();
                  myCommand.Transaction = myTransaction;
              }

              catch (SqlException)
              {
                  throw new Exception("Brisanje neuspešno");
              }

              finally
              {
                  if (!error)
                  {
                      myTransaction.Commit();
                      MessageBox.Show("Brisanje uspešno završeno", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                  }
                  myConnection.Close();

                  if (error)
                  {
                      // Nedra.DataSet1TableAdapters.QueriesTableAdapter adapter = new Nedra.DataSet1TableAdapters.QueriesTableAdapter();
                  }
              }
          }

        public void UpdatePrijemKontejneraVozStavkeRB(int RB, int ID)
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(s_connection);
            SqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "UpdatePrijemKontejneraVozStavkeRB";
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@ID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = ID;
            myCommand.Parameters.Add(parameter);

            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@RB";
            parameter1.SqlDbType = SqlDbType.Int;
            parameter1.Direction = ParameterDirection.Input;
            parameter1.Value = RB;
            myCommand.Parameters.Add(parameter1);

            myConnection.Open();
            SqlTransaction myTransaction = myConnection.BeginTransaction();
            myCommand.Transaction = myTransaction;
            bool error = true;
            try
            {
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myTransaction = myConnection.BeginTransaction();
                myCommand.Transaction = myTransaction;
            }

            catch (SqlException)
            {
                throw new Exception("Brisanje neuspešno");
            }

            finally
            {
                if (!error)
                {
                    myTransaction.Commit();
                    MessageBox.Show("Brisanje uspešno završeno", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                myConnection.Close();

                if (error)
                {
                    // Nedra.DataSet1TableAdapters.QueriesTableAdapter adapter = new Nedra.DataSet1TableAdapters.QueriesTableAdapter();
                }
            }
        }

        public void UpdateOtpremaKontejneraVozStavkeRB(int RB, int ID)
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(s_connection);
            SqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "UpdateOtpremaKontejneraVozStavkeRB";
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@ID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = ID;
            myCommand.Parameters.Add(parameter);

            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@RB";
            parameter1.SqlDbType = SqlDbType.Int;
            parameter1.Direction = ParameterDirection.Input;
            parameter1.Value = RB;
            myCommand.Parameters.Add(parameter1);

            myConnection.Open();
            SqlTransaction myTransaction = myConnection.BeginTransaction();
            myCommand.Transaction = myTransaction;
            bool error = true;
            try
            {
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myTransaction = myConnection.BeginTransaction();
                myCommand.Transaction = myTransaction;
            }

            catch (SqlException)
            {
                throw new Exception("Brisanje neuspešno");
            }

            finally
            {
                if (!error)
                {
                    myTransaction.Commit();
                    MessageBox.Show("Brisanje uspešno završeno", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                myConnection.Close();

                if (error)
                {
                    // Nedra.DataSet1TableAdapters.QueriesTableAdapter adapter = new Nedra.DataSet1TableAdapters.QueriesTableAdapter();
                }
            }
        }

    }
}



