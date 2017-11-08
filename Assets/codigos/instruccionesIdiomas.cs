using UnityEngine;
using System.Collections;

public class instruccionesIdiomas : MonoBehaviour {
	public TextMesh txtIntrucciones, txtfinjuego, aciertos, errores, menu, jugar, jugarp;

	void Awake () {
		if (fnmateDatos.fmDatos.lenguaje == 0) {
			if (Application.loadedLevelName == "02_Mod1_juno") {
				txtIntrucciones.text = "De cada par de meteoritos toca el que\nse te indique para destruirlos y\nevitar que caigan en tu casa, puedes\nganar balas de cañon para defenderte\ncuando falles.";
			} else if (Application.loadedLevelName == "03_Mod1_jdos") {
				txtIntrucciones.text = "De cada par de meteoritos toca el que\nse te indique para destruirlos y\nevitar que caigan en tu casa, puedes\nganar balas de cañon para defenderte\ncuando falles.";
			} else if (Application.loadedLevelName == "04_Mod1_jtres") {
				txtIntrucciones.text = "De cada par de meteoritos toca el que\nse te indique para destruirlos y\nevitar que caigan en tu casa, puedes\nganar balas de cañon para defenderte\ncuando falles.";
			} else if (Application.loadedLevelName == "05_Mod1_jcuatro") {
				txtIntrucciones.text = "De cada par de meteoritos toca el que\nse te indique para destruirlos y\nevitar que caigan en tu casa, puedes\nganar balas de cañon para defenderte\ncuando falles.";
			} else if (Application.loadedLevelName == "06_Mod2_juno") {
				txtIntrucciones.text = "De cada par de tiburones toca el que\ntenga el resultado de la multiplicacion,\npuedes recolectar corchos de madera\npara cuando los necesites.";
			} else if (Application.loadedLevelName == "07_Mod2_jdos") {
				txtIntrucciones.text = "De cada par de tiburones toca el que\ncomplemente la multiplicacion, puedes\nrecolectar corchos de madera para\ncuando los necesites.";
			} else if (Application.loadedLevelName == "08_Mod3_juno") {
				txtIntrucciones.text = "De cada grupo de fracciones toca la que\nse te indica, puedes recolectar escudos\npara cuando los necesites.";
			}
			txtfinjuego.text = "Partida terminada";
			aciertos.text = "Aciertos:";
			errores.text = "Errores:";
			menu.text = "Menu";
			jugarp.text = "Jugar";
			jugar.text = "Otra";
		} else {
			if (Application.loadedLevelName == "02_Mod1_juno") {
				txtIntrucciones.text = "Of each pair of meteorites touches\nwhich prompted to destroy them and\nprevent them from falling into your\nhouse, you can earn cannonballs to \ndefend yourself when you fail.";
			} else if (Application.loadedLevelName == "03_Mod1_jdos") {
				txtIntrucciones.text = "Of each pair of meteorites touches\nwhich prompted to destroy them and\nprevent them from falling into your\nhouse, you can earn cannonballs to \ndefend yourself when you fail.";
			} else if (Application.loadedLevelName == "04_Mod1_jtres") {
				txtIntrucciones.text = "Of each pair of meteorites touches\nwhich prompted to destroy them and\nprevent them from falling into your\nhouse, you can earn cannonballs to \ndefend yourself when you fail.";
			} else if (Application.loadedLevelName == "05_Mod1_jcuatro") {
				txtIntrucciones.text = "Of each pair of meteorites touches\nwhich prompted to destroy them and\nprevent them from falling into your\nhouse, you can earn cannonballs to \ndefend yourself when you fail.";
			} else if (Application.loadedLevelName == "06_Mod2_juno") {
				txtIntrucciones.text = "Of each pair of sharks plays have the\nresult of the multiplication , you can,\ncollect wooden corks when needed.";
			} else if (Application.loadedLevelName == "07_Mod2_jdos") {
				txtIntrucciones.text = "Of each pair of sharks touches to\ncomplement multiplication , you can\ncollect wood corks when you need them.";
			} else if (Application.loadedLevelName == "08_Mod3_juno") {
				txtIntrucciones.text = "Each group of fractions touches that\ntells you , you can collect shields when\nneeded.";
			}
			txtfinjuego.text = "Finished game";
			aciertos.text = "Correct:";
			errores.text = "mistakes:";
			menu.text = "Menu";
			jugarp.text = "Play";
			jugar.text = "Again";
		}
	}

}
