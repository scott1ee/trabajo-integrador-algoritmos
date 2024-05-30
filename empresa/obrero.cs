/*
 * Proyecto N°1
 * Integrantes del Grupo: Gonzáles Santiago, Ledesma Mauricio, Herrera Franco
 */
 
using System;

public class Obrero
{
//	Atributos
    protected string NombreApellido { get; set; }
    protected string DniObrero { get; set; }
    protected int Legajo { get; set; }
    protected double Sueldo { get; set; }
    protected string Cargo { get; set; }

//  Constructor
    public Obrero(string nombreApellido, string dniObrero, int legajo, double sueldo, string cargo)
    {
        NombreApellido = nombreApellido;
        DniObrero = dniObrero;
        Legajo = legajo;
        Sueldo = sueldo;
        Cargo = cargo;
    }

//  Metodo
    public string EstadoObrero()
    {
        return "Obrero: " + NombreApellido + ", Cargo: " + Cargo + ", Sueldo: " + Cargo;
    }
}
