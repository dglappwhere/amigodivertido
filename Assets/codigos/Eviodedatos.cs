//using UnityEngine;
//using System.Collections;
//using System;
//using System.Net;
//using System.Net.Mail;
//using System.Net.Security;
//using System.Security.Cryptography.X509Certificates;
//using UnityEngine.UI;
//public class Eviodedatos : MonoBehaviour {
//
//	public string micorreo,contraseña,correodestino,asunto,cuerpoMail;
//	public Text estado;
//	// Use this for initialization
//	void OnMouseDown () {
//		asunto = "Correo numero: " + fnmateDatos.fmDatos.Nmails.ToString () + ", de Jugador: "
//			+ fnmateDatos.fmDatos.nombrejugador + ", Edad: " + fnmateDatos.fmDatos.edad.ToString()+", nombre escuela: " + fnmateDatos.fmDatos.nombreEscuela+".";
//		cuerpoMail = "DATOS TOTALES!!!" +
//			"\n" + "----------MODULO 1----------" +
//			"\n" +
//			"--JUEGO 1--" +
//			"\n" +
//			"Veces jugado: " + fnmateDatos.fmDatos.VJJ1M1.ToString () +
//			"\n" +
//			"Aciertos totales: " + fnmateDatos.fmDatos.AJ1M1.ToString () +
//			"\n" +
//			"Errores totales: " + fnmateDatos.fmDatos.EJ1M1.ToString () +
//			"\n" +
//			"\n" +
//			"--JUEGO 2--" +
//			"\n" +
//			"Veces jugado: " + fnmateDatos.fmDatos.VJJ2M1.ToString () +
//			"\n" +
//			"Aciertos totales: " + fnmateDatos.fmDatos.AJ2M1.ToString () +
//			"\n" +
//			"Errores totales: " + fnmateDatos.fmDatos.EJ2M1.ToString () +
//			"\n" +
//			"\n" +
//			"--JUEGO 3--" +
//			"\n" +
//			"Veces jugado: " + fnmateDatos.fmDatos.VJJ3M1.ToString () +
//			"\n" +
//			"Aciertos totales: " + fnmateDatos.fmDatos.AJ3M1.ToString () +
//			"\n" +
//			"Errores totales: " + fnmateDatos.fmDatos.EJ3M1.ToString () +
//			"\n" +
//			"\n" +
//			"--JUEGO 4--" +
//			"\n" +
//			"Veces jugado: " + fnmateDatos.fmDatos.VJJ4M1.ToString () +
//			"\n" +
//			"Aciertos totales: " + fnmateDatos.fmDatos.AJ4M1.ToString () +
//			"\n" +
//			"Errores totales: " + fnmateDatos.fmDatos.EJ4M1.ToString () +
//			"\n" +
//			"\n" +
//			"\n" +
//			"\n" + "----------MODULO 2---------" +
//			"\n" +
//			"\n" +
//			"--JUEGO 1--" +
//			"\n" +
//			"Veces jugado: " + fnmateDatos.fmDatos.VJJ1M2.ToString () +
//			"\n" +
//			"Aciertos totales: " + fnmateDatos.fmDatos.AJ1M2.ToString () +
//			"\n" +
//			"Errores totales: " + fnmateDatos.fmDatos.EJ1M2.ToString () +
//			"\n" +
//			"\n" +
//			"--JUEGO 2--" +
//			"\n" +
//			"Veces jugado: " + fnmateDatos.fmDatos.VJJ2M2.ToString () +
//			"\n" +
//			"Aciertos totales: " + fnmateDatos.fmDatos.AJ2M2.ToString () +
//			"\n" +
//			"Errores totales: " + fnmateDatos.fmDatos.EJ2M2.ToString () +
//			"\n" +
//			"\n" +
//			"\n" +
//			"\n" + "----------MODULO 3---------" +
//			"\n" +
//			"\n" +
//			"--JUEGO 1--" +
//			"\n" +
//			"Veces jugado: " + fnmateDatos.fmDatos.VJJ1M3.ToString () +
//			"\n" +
//			"Aciertos totales: " + fnmateDatos.fmDatos.AJ1M3.ToString () +
//			"\n" +
//			"Errores totales: " + fnmateDatos.fmDatos.EJ1M3.ToString ();
//		MandarDatos();
//	}
//	
//
//	void MandarDatos () {
//		MailMessage mail = new MailMessage();
//		
//		mail.From = new MailAddress(micorreo);
//		mail.To.Add(correodestino);
//		mail.Subject = asunto.ToString();
//		mail.Body = cuerpoMail;
//		
//		SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
//		smtpServer.Port = 465;
//		smtpServer.Credentials = new System.Net.NetworkCredential(micorreo, contraseña) as ICredentialsByHost;
//		smtpServer.EnableSsl = true;
//		ServicePointManager.ServerCertificateValidationCallback = 
//			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
//		{ return true; };
//		try{
//			smtpServer.Send(mail);
//			estado.color = Color.green;
//			estado.text="Datos enviados =)";
//			fnmateDatos.fmDatos.Nmails+=1;
//		}
//		catch
//		{
//			estado.color = Color.white;
//			estado.text="Datos no enviados :(" +
//				"\n" +"Asegure una conexion" +
//				"\n" + "a internet y vuelva" +
//				"\n" + "a inentarlo.";
//		}
//	}
//}
