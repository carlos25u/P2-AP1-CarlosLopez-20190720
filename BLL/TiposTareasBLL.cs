using P2_AP1_CarlosLopez_20190720.DAL;
using P2_AP1_CarlosLopez_20190720.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_CarlosLopez_20190720.BLL
{
    class TiposTareasBLL
    {
        public static List<TiposTareas> GetList(Expression<Func<TiposTareas, bool>> criterio)
        {
            var lista = new List<TiposTareas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposTareas.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<TiposTareas> GetTiposTareas()
        {
            var lista = new List<TiposTareas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposTareas.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static TiposTareas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TiposTareas tipo;

            try
            {
                tipo = contexto.TiposTareas.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipo;
        }
    }
}
