using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class escuchadorlenguajes : MonoBehaviour {
	public TextMesh nombre, edad, infmod01, infmod02, infmod03;
	public Text contra, configuraciones, contraseñatxt, txtacceder, txtcancelar, txtestadisticas, txtcreditos;

	void Awake()
	{
		if (fnmateDatos.fmDatos.lenguaje == 0) {
			langES ();
		} else {
			langEN();
		}
	}
	void Start()
	{
		NotificationCenter.DefaultCenter ().AddObserver (this, "langES");
		NotificationCenter.DefaultCenter ().AddObserver (this, "langEN");
	}
	void langES()
	{
		nombre.text = "Nombre:";
		edad.text = "Edad:";
		contraseñatxt.text = "Contraseña...";
		txtacceder.text = "Acceder!";
		txtcancelar.text = "Cancelar!";
		infmod01.text = "Modulo 1: En este modulo aprenderas a\nidentificar rapidamente si un numero\nsolo, sumado o restado es mayor o menor\na otro.";
		infmod02.text = "Modulo 2: Este modulo te ayudara a\nagilizar tu capacidad de resolver\nmultiplicaciones, identificando el numero\nque complemente cada operación. ";
		infmod03.text = "Modulo 3: Este modulo te ayudara a\na identificar fracciones representadas\ngráficamente.";
		contra.text = "Contraseña:\nfunny123";
		configuraciones.text = "CONFIGURACIONES\n\nNIVELES\n─ Bloquea y desbloquea niveles según sea necesario.\n─ Tocar nivel a desbloquear."+
			"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nESTADISTICAS\nPara ver las estadisticas de clic al icono.";
		txtcreditos.text="Juego educativo Funny Mate de\nDaniel Galeana López, estudiante de\n Ciencias y Tecnologías de la Información \nen la escuela UACyTI UAGro." +
				"\n─ Creditos - Funny Mate─\n\nIdea\nDaniel Galeana López.\n\nDiseño\nDaniel Galeana López.\n\nSprites\nDaniel Galeana López.\n\nTexturas\nDaniel Galeana López." +
				"\n\nProgramación\nDaniel Galeana López.\n\nOtros\nhttp://www.arcadesonic.com/capitan_mono/img/isla.png\nhttps://cdn2.iconfinder.com/data/icons/windows-8-metro-style/256/statistics.png" +
				"\n\nhttp://previews.123rf.com/images/benchart/benchart1310/benchart131000019/23102159-Illustration-of-a-cartoon-seamless-never-ending-horizontal-spring-or-summer-landscape-background-loo-Stock-Vector.jpg" +
				"\n\nhttp://www.pubzi.com/rueda-de-picos~es~PJxp5zKHMzM.html\n\nUnity3D";
	}
	void langEN()
	{
		nombre.text = "Name:";
		edad.text = "Age:";
		contraseñatxt.text = "Password...";
		txtacceder.text = "To access!";
		txtcancelar.text = "Cancel!";
		infmod01.text = "Module 1 Smaller or higher:\nIn this module you will learn quickly\nidentify if a number alone, added or\nsubtracted is greater or less than another .";
		infmod02.text = "Module 2 The missing:\nThis module will help you streamline your\nability to solve multiplications , identifying\nthe number that complements each\noperation.";
		infmod03.text = "Module 3 Fractions in the air:\nThis module will help you\nidentify fractions represented\ngraphically.";
		contra.text = "Password:\nfunny123";
		configuraciones.text = "CONFIGURATIONS\n\nLEVELS\n─ Lock and unlock levels as needed.\n─ Touch level to unlock."+
			"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nSTATISTICS\nTo view statistics click the icon.";
		txtcreditos.text="Sorry for the bad translation\n\n" +
			"Juego educativo Funny Mate de\nDaniel Galeana López, estudiante de\n Ciencias y Tecnologías de la Información \nen la escuela UACyTI UAGro." +
				"\n─ Creditos - Funny Mate─\n\nIdea\nDaniel Galeana López.\n\nDiseño\nDaniel Galeana López.\n\nSprites\nDaniel Galeana López.\n\nTexturas\nDaniel Galeana López." +
				"\n\nProgramación\nDaniel Galeana López.\n\nOtros\nhttp://www.arcadesonic.com/capitan_mono/img/isla.png\nhttps://cdn2.iconfinder.com/data/icons/windows-8-metro-style/256/statistics.png" +
				"\n\nhttp://previews.123rf.com/images/benchart/benchart1310/benchart131000019/23102159-Illustration-of-a-cartoon-seamless-never-ending-horizontal-spring-or-summer-landscape-background-loo-Stock-Vector.jpg" +
				"\n\nhttp://www.pubzi.com/rueda-de-picos~es~PJxp5zKHMzM.html\n\nUnity3D";
	}
}
