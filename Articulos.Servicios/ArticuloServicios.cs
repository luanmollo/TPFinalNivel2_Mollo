using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Articulos.Modelo;
using Articulos.Datos;

namespace Articulos.Servicios
{
    public class ArticuloServicios
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta("select a.Id, Codigo, Nombre, a.Descripcion, ImagenUrl, m.Descripcion Marca, c.Descripcion Categoria, a.IdMarca, a.IdCategoria from articulos a, marcas m, categorias c where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (int)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);                    
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }   

}
