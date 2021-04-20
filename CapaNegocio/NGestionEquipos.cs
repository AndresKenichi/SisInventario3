using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
namespace CapaNegocio
{
    public class NGestionEquipos
    {

        int id_mov, id_us, id_eq, id_dep, id_enc, id_emp,est;
        string descripcion;
        DateTime fecha_mov;

        public NGestionEquipos(int id_mov, int id_us, int id_eq, int id_dep, int id_enc, int id_emp, int est, string descripcion, DateTime fecha_mov)
        {
            this.id_mov = id_mov;
            this.id_us = id_us;
            this.id_eq = id_eq;
            this.id_dep = id_dep;
            this.id_enc = id_enc;
            this.id_emp = id_emp;
            this.est = est;
            this.descripcion = descripcion;
            this.fecha_mov = fecha_mov;
        }
        public NGestionEquipos()
        {
            
        }

        public int Id_mov { get => id_mov; set => id_mov = value; }
        public int Id_us { get => id_us; set => id_us = value; }
        public int Id_eq { get => id_eq; set => id_eq = value; }
        public int Id_dep { get => id_dep; set => id_dep = value; }
        public int Id_enc { get => id_enc; set => id_enc = value; }
        public int Id_emp { get => id_emp; set => id_emp = value; }
        public int Est { get => est; set => est = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_mov { get => fecha_mov; set => fecha_mov = value; }


        public string AsignarEquipos(int id_equi,int id_empleado,int id_encabezado,string  descripc,int id_departamento,DateTime fec_mov,int id_usuario,int estado) {

            DGestionEquipos ge = new DGestionEquipos();

            ge.Id_equipo = id_equi;
            ge.Id_empleado = id_empleado;
            ge.Id_encabezado = id_encabezado;
            ge.Descripcion = descripc;
            ge.Id_departamento = id_departamento;
            ge.Fecha_movimiento = fec_mov;
            ge.Id_usuario = id_usuario;
            ge.Estado = estado;

            return ge.AsignarEquipos(ge);
            
        }
    }
}
