using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SocialPlatforms;

public class fnmateDatos : MonoBehaviour {
	//variable nombre del jugados
	public string nombrejugador = "";
	public int edad = 0;
	public int lenguaje = 0;
	//Variables de puntuaciones de juego
	public int
		//VecesJugadasJuenoUnoModuloUno(VJG1M1)
		VJJ1M1 = 0,
		VJJ2M1 = 0,
		VJJ3M1 = 0,
		VJJ4M1 = 0,
		VJJ1M2 = 0,
		VJJ2M2 = 0,
		VJJ1M3 = 0,
		//Aciertos en cada nivel
		AJ1M1 = 0,
		AJ2M1 = 0,
		AJ3M1 = 0,
		AJ4M1 = 0,
		AJ1M2 = 0,
		AJ2M2 = 0,
		AJ1M3 = 0,
		//Errores en cada nivel
		EJ1M1 = 0,
		EJ2M1 = 0,
		EJ3M1 = 0,
		EJ4M1 = 0,
		EJ1M2 = 0,
		EJ2M2 = 0,
		EJ1M3 = 0;
	//Bloqueadores de niveles
	public int
		BMOD1J2 = 0,
		BMOD1J3 = 0,
		BMOD1J4 = 0,
		BMOD2 = 0,
		BMOD2J1 = 0,
		BMOD2J2 = 0,
		BMOD3 = 0,
		BMOD3J1 = 0;

	//variable pasa saber si es la primera vez que entra y si ya se reistro
	public int primeravez = 0;
	//variables de datos de jugador
	public int aciertosT = 0;
	public int erroresT = 0;
	//Puntuaciones en niveles
	public int junoelmayordelosnumeros = 0 ;
	//balas
	public int balas = 3 ;
	//orden
	public bool mayor;
	//Modulo2
	public int resultMultiplicacion=0;
	//Modulo3
	public string fraccionGenerada="";
	//Numero de mails enviados
	public int Nmails=0;
	public static fnmateDatos fmDatos;	
	private String rutaArchivo;
	
	void Awake(){
		rutaArchivo = Application.persistentDataPath + "/FunnyMate.dat";
		if(fmDatos==null){
			fmDatos = this;
			DontDestroyOnLoad(gameObject);
		}else if(fmDatos!=this){
			Destroy(gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {
		Cargar ();
	}
	public void Guardar(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(rutaArchivo);
		
		DatosAGuardar datos = new DatosAGuardar();
		//nombre d ejugador
		datos.nombrejugador = nombrejugador;
		datos.edad = edad;
		datos.lenguaje = lenguaje;
		//Variables de puntuaciones de juego
		datos.VJJ1M1 = VJJ1M1;
		datos.VJJ2M1 = VJJ2M1;
		datos.VJJ3M1 = VJJ3M1;
		datos.VJJ4M1 = VJJ4M1;
		datos.VJJ1M2 = VJJ1M2;
		datos.VJJ2M2 = VJJ2M2;
		datos.VJJ1M3 = VJJ1M3;
		//Aciertos en cada nivel
		datos.AJ1M1 = AJ1M1;
		datos.AJ2M1 = AJ2M1;
		datos.AJ3M1 = AJ3M1;
		datos.AJ4M1 = AJ4M1;
		datos.AJ1M2 = AJ1M2;
		datos.AJ2M2 = AJ2M2;
		datos.AJ1M3 = AJ1M3;
		//Errores en cada nivel
		datos.EJ1M1 = EJ1M1;
		datos.EJ2M1 = EJ2M1;
		datos.EJ3M1 = EJ3M1;
		datos.EJ4M1 = EJ4M1;
		datos.EJ1M2 = EJ1M2;
		datos.EJ2M2 = EJ2M2;
		datos.EJ1M3 = EJ1M3;

		//BLOC DE NIVELES
		datos.BMOD1J2 = BMOD1J2;
		datos.BMOD1J3 = BMOD1J3;
		datos.BMOD1J4 = BMOD1J4;
		datos.BMOD2 = BMOD2;
		datos.BMOD2J1 = BMOD2J1;
		datos.BMOD2J2 = BMOD2J2;
		datos.BMOD3 = BMOD3;
		datos.BMOD3J1 = BMOD3J1;
		//primera vez que se entra al juego
		datos.primeravez = primeravez;
		//Datos de usuario
		datos.aciertosT = aciertosT;
		datos.erroresT = erroresT;
		// puntuaciones en niveles
		datos.junoelmayordelosnumeros = junoelmayordelosnumeros;
		//balas
		datos.balas = balas;
		//orden
		datos.mayor = mayor;
		//Modulo 2
		datos.resultMultiplicacion = resultMultiplicacion;
		//Modulo 3
		datos.fraccionGenerada = fraccionGenerada;
		datos.Nmails = Nmails;
		bf.Serialize(file, datos);
		file.Close();
	}	
	void Cargar(){
		if(File.Exists(rutaArchivo)){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(rutaArchivo, FileMode.Open);
			DatosAGuardar datos = (DatosAGuardar) bf.Deserialize(file);
			//nombre jugador
			nombrejugador = datos.nombrejugador;
			edad = datos.edad;
			lenguaje = datos.lenguaje;
			//Variables de puntuaciones de juego
			VJJ1M1 = datos.VJJ1M1;
			VJJ2M1 = datos.VJJ2M1;
			VJJ3M1 = datos.VJJ3M1;
			VJJ4M1 = datos.VJJ4M1;
			VJJ1M2 = datos.VJJ1M2;
			VJJ2M2 = datos.VJJ2M2;
			VJJ1M3 = datos.VJJ1M3;
			//Aciertos en cada nivel
			AJ1M1 = datos.AJ1M1;
			AJ2M1 = datos.AJ2M1;
			AJ3M1 = datos.AJ3M1;
			AJ4M1 = datos.AJ4M1;
			AJ1M2 = datos.AJ1M2;
			AJ2M2 = datos.AJ2M2;
			AJ1M3 = datos.AJ1M3;
			//Errores en cada nivel
			EJ1M1 = datos.EJ1M1;
			EJ2M1 = datos.EJ2M1;
			EJ3M1 = datos.EJ3M1;
			EJ4M1 = datos.EJ4M1;
			EJ1M2 = datos.EJ1M2;
			EJ2M2 = datos.EJ2M2;
			EJ1M3 = datos.EJ1M3;
			//BLOC NIVELES
			BMOD1J2 = datos.BMOD1J2;
			BMOD1J3 = datos.BMOD1J3;
			BMOD1J4 = datos.BMOD1J4;
			BMOD2 = datos.BMOD2;
			BMOD2J1 = datos.BMOD2J1;
			BMOD2J2 = datos.BMOD2J2;
			BMOD3 = datos.BMOD3;
			BMOD3J1 = datos.BMOD3J1;
			//primera vez que se entra al juego
			primeravez = datos.primeravez;
			//datos del jugador
			aciertosT = datos.aciertosT;
			erroresT = datos.erroresT;
			//puntuaciones en niveles
			junoelmayordelosnumeros = datos.junoelmayordelosnumeros;
			//balas
			balas = datos.balas;
			//orden
			mayor = datos.mayor;
			//Modulo 2
			resultMultiplicacion = datos.resultMultiplicacion;
			//Modulo 3
			fraccionGenerada = datos.fraccionGenerada;
			Nmails = datos.Nmails;
			file.Close();
		}else{
			//FileStream file = File.Create(rutaArchivo);
			nombrejugador = "";
			edad = 0;
			lenguaje = 0;
			//Variables de puntuaciones de juego
			VJJ1M1 = 0;
			VJJ2M1 = 0;
			VJJ3M1 = 0;
			VJJ4M1 = 0;
			VJJ1M2 = 0;
			VJJ2M2 = 0;
			VJJ1M3 = 0;
			//Aciertos en cada nivel
			AJ1M1 = 0;
			AJ2M1 = 0;
			AJ3M1 = 0;
			AJ4M1 = 0;
			AJ1M2 = 0;
			AJ2M2 = 0;
			AJ1M3 = 0;
			//Errores en cada nivel
			AJ1M1 = 0;
			AJ2M1 = 0;
			AJ3M1 = 0;
			AJ4M1 = 0;
			AJ1M2 = 0;
			AJ2M2 = 0;
			AJ1M3 = 0;
			//bloc niveles
			BMOD1J2 = 0;
			BMOD1J3 = 0;
			BMOD1J4 = 0;
			BMOD2 = 0;
			BMOD2J1 = 0;
			BMOD2J2 = 0;
			BMOD3 = 0;
			BMOD3J1 = 0;
			//variable para saber si es la primera vez que juega
			primeravez = 0;
			junoelmayordelosnumeros = 0;
			balas = 3;
			mayor=false;
			fraccionGenerada="FnMate!";
			Nmails=1;
		}
	}
}
[Serializable]
class DatosAGuardar{
	//variable nombre jugador
	public string nombrejugador;
	public int edad;
	public int lenguaje;
	//variable primera vez que se entra al juego
	public int primeravez;
	//variables de datos de jugador
	public int aciertosT, erroresT;
	//puntuaciones en niveles
	public int junoelmayordelosnumeros;
	//balas
	public int balas;
	//orden
	public bool mayor;
	//modulo 2
	public int resultMultiplicacion;
	//Modulo 3
	public string fraccionGenerada;

	public int
		//VecesJugadasJuenoUnoModuloUno(VJG1M1)
		VJJ1M1,
		VJJ2M1,
		VJJ3M1,
		VJJ4M1,
		VJJ1M2,
		VJJ2M2,
		VJJ1M3,
		//Aciertos en cada nivel
		AJ1M1,
		AJ2M1,
		AJ3M1,
		AJ4M1,
		AJ1M2,
		AJ2M2,
		AJ1M3,
		//Errores en cada nivel
		EJ1M1,
		EJ2M1,
		EJ3M1,
		EJ4M1,
		EJ1M2,
		EJ2M2,
		EJ1M3;
	public int
		BMOD1J2,
		BMOD1J3,
		BMOD1J4,
		BMOD2,
		BMOD2J1,
		BMOD2J2,
		BMOD3,
		BMOD3J1;
	public int Nmails;
}