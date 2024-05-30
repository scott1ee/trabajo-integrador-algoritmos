/*
 * Proyecto N°1
 * Integrantes del Grupo: Gonzáles Santiago, Ledesma Mauricio, Herrera Franco
 */

using System;

public class Obra
{
//	Atributos
    private string NombrePropietario { get; set; }
    private string DniPropietario { get; set; }
    private int CodigoInterno { get; set; }
    private string TipoObra { get; set; }
    private double EstadoAvance { get; set; }
    protected JefeDeObra JefeObra { get; set; }
    private int Costo { get; set; }
    private string Estado { get; set; }

//  Constructor
    public Obra(string nombrePropietario, string dniPropietario, int codigoInterno, string tipoObra, double estadoAvance, JefeDeObra jefeObra, int costo, string estado)
    {
        NombrePropietario = nombrePropietario;
        DniPropietario = dniPropietario;
        CodigoInterno = codigoInterno;
        TipoObra = tipoObra;
        EstadoAvance = estadoAvance;
        JefeObra = jefeObra;
        Costo = costo;
        Estado = estado;
    }

//  Metodo    
    public void NuevoJefeObra(JefeDeObra jefe)
    {
        JefeObra = jefe;
    }
}
