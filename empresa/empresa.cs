/*
 * Proyecto N°1
 * Integrantes del Grupo: Gonzáles Santiago, Ledesma Mauricio, Herrera Franco
 */

using System;
using System.Collections;

public class Empresa
{
//	Atributos
    private string NombreEmpresa { get; set; }
    private ArrayList Obreros { get; set; }
    private ArrayList GruposObreros { get; set; }
    private ArrayList JefesDeObra { get; set; }
    private ArrayList ObrasEnEjecucion { get; set; }
    private ArrayList ObrasFinalizadas { get; set; }

//  Constructor
    public Empresa(string nombreEmpresa)
    {
        NombreEmpresa = nombreEmpresa;
        Obreros = new ArrayList();
        GruposObreros = new ArrayList();
        JefesDeObra = new ArrayList();
        ObrasEnEjecucion = new ArrayList();
        ObrasFinalizadas = new ArrayList();
    }

//  Metodos
    public void ContratarObrero(string nombreApellido, string dni, string cargo)
    {
        Obrero nuevoObrero = new Obrero(nombreApellido, dni, Obreros.Count + 1, 0, cargo);
        Obreros.Add(nuevoObrero);
    }

    public void EliminarObrero(string dni, GrupoDeObreros grupo)
    {
        Obrero obreroEliminar = null;
        foreach (Obrero obrero in Obreros)
        {
            if (obrero.DniObrero == dni)
            {
                obreroEliminar = obrero;
                break;
            }
        }

        if (obreroEliminar != null)
        {
            Obreros.Remove(obreroEliminar);
            grupo.EliminarObrero(obreroEliminar);
        }
    }

    public void ContratarJefeDeObra(string nombre, string apellido, string dni, int legajo, double sueldo, string cargo, double plusSueldo, Obra obra)
    {
        JefeDeObra nuevoJefe = new JefeDeObra(nombre + " " + apellido, dni, legajo, sueldo, cargo, plusSueldo);
        JefesDeObra.Add(nuevoJefe);
        obra.NuevoJefeObra(nuevoJefe);
    }

    public void ImprimirListado()
    {
        foreach (Obrero obrero in Obreros)
        {
            Console.WriteLine("Obreros: " + obrero.EstadoObrero());
        }
    }

    public void ModificarEstadoObra(Obra obra, double nuevoEstado)
    {
        obra.EstadoAvance = nuevoEstado;
        if (nuevoEstado >= 100)
        {
            ObrasEnEjecucion.Remove(obra);
            ObrasFinalizadas.Add(obra);
        }
    }

    public void DarDeBajaJefe(JefeDeObra jefe)
    {
        JefesDeObra.Remove(jefe);
    }
}
