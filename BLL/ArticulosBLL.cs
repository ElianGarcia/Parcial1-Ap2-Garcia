using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Garcia.DAL;
using Parcial1_Ap2_Garcia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Garcia.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            if (!Existe(articulo.ID))
                return Insertar(articulo);
            else
                return Modificar(articulo);
        }

        private static bool Insertar(Articulos articulo)
        {
            bool insertado = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.articulos.Add(articulo);
                insertado = contexto.SaveChanges() > 0;
            } catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return insertado;
        }

        private static bool Modificar(Articulos articulo)
        {
            bool modificado = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                modificado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return modificado;
        }

        private static bool Existe(int iD)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.articulos.Any(e => e.ID == iD);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool Eliminar(int iD)
        {
            bool eliminado = false;
            Contexto contexto = new Contexto();

            try
            {
                var articulo = contexto.articulos.Find(iD);

                if(articulo != null)
                {
                    contexto.articulos.Remove(articulo);
                    eliminado = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return eliminado;
        }

        public static Articulos Buscar (int iD)
        {
            Contexto contexto = new Contexto();
            Articulos articulo;

            try
            {
                articulo = contexto.articulos.Find(iD);
            } catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return articulo;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> criterio)
        {
            List<Articulos> lista = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.articulos.Where(criterio).ToList();
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
    }
}
