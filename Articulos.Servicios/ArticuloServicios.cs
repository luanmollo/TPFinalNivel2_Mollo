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
                datos.ConfigurarConsulta("select a.Id, Codigo, Nombre, a.Descripcion, ImagenUrl, m.Descripcion Marca, c.Descripcion Categoria, a.IdMarca, a.IdCategoria, Precio from articulos a, marcas m, categorias c where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
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
                    aux.Precio = Math.Truncate((decimal)datos.Lector["Precio"] * 100) / 100;

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

        public List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select a.Id, Codigo, Nombre, a.Descripcion, ImagenUrl, m.Descripcion Marca, c.Descripcion Categoria, a.IdMarca, a.IdCategoria, Precio from articulos a, marcas m, categorias c where a.IdMarca = m.Id and a.IdCategoria = c.Id";

                switch (campo)
                {
                    case "Código":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += " and Codigo like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " and Codigo like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and Codigo like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += " and Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " and Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Descripción":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += " and a.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " and a.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and a.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Marca":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += " and m.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " and m.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and m.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Categoría":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += " and c.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " and c.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and c.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += " and Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += " and Precio < " + filtro;
                                break;
                            case "Igual a":
                                consulta += " and Precio = " + filtro;
                                break;
                        }
                        break;

                }

                datos.ConfigurarConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
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
                    aux.Precio = Math.Truncate((decimal)datos.Lector["Precio"] * 100) / 100;

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

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta("insert into articulos(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.ConfigurarParametros("@Codigo", nuevo.Codigo);
                datos.ConfigurarParametros("@Nombre", nuevo.Nombre);
                datos.ConfigurarParametros("@Descripcion", nuevo.Descripcion);
                datos.ConfigurarParametros("@IdMarca", nuevo.Marca.Id);
                datos.ConfigurarParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.ConfigurarParametros("@ImagenUrl", nuevo.UrlImagen);
                datos.ConfigurarParametros("@Precio", nuevo.Precio);

                datos.EjecutarAccion();

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
