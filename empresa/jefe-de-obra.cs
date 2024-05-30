/*
 * Proyecto N°1
 * Integrantes del Grupo: Gonzáles Santiago, Ledesma Mauricio, Herrera Franco
 */
 
using System;

public class JefeDeObra : Obrero
{
//	Atributo
    protected double PlusSueldo { get; set; }

//  Constructor
    public JefeDeObra(string nombreApellido, string dniObrero, int legajo, double sueldo, string cargo, double plusSueldo)
        : base(nombreApellido, dniObrero, legajo, sueldo, cargo)
    {
        PlusSueldo = plusSueldo;
    }

//  Metodos
    public void NumeroObra(Obra obra)
    {
        // To do
    }

    public void AsignarGrupo(GrupoDeObreros grupo)
    {
        // To do
    }
}
