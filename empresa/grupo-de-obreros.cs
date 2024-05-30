/*
 * Proyecto N°1
 * Integrantes del Grupo: Gonzáles Santiago, Ledesma Mauricio, Herrera Franco
 */
 
using System;
using System.Collections;

public class GrupoDeObreros
{
//	Atributos
    private int CodigoObra { get; set; }
    private ArrayList Integrantes { get; set; }

//	Constructor
    public GrupoDeObreros(int codigoObra)
    {
        CodigoObra = codigoObra;
        Integrantes = new ArrayList();
    }

//  Metodos
    public void AgregarObrero(Obrero obrero)
    {
        Integrantes.Add(obrero);
    }

    public void EliminarObrero(Obrero obrero)
    {
        Integrantes.Remove(obrero);
    }
}
