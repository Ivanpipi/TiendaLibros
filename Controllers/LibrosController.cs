using System;
using Microsoft.AspNetCore.Mvc;
using TiendaLibros.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;

using X.PagedList.Mvc.Core;
using X.PagedList;

namespace TiendaLibros.Controllers
{



    public class LibrosController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public LibrosController(IWebHostEnvironment hostEnvironment)
        {
            _hostingEnvironment = hostEnvironment;
        }

        //Lista Estatica Libros
        static List<Libro> Lista = new List<Libro>(){
            new Libro(){Titulo = "El arte de la musica",Autor = "Mario Luis",Categoria = "Biografia",AñoLanzamiento = 1998,Precio=250,idLibro=1,FotoId=100,FotoRuta="100.jpg"},
            new Libro(){Titulo = "Harry Potter",Autor = "J. K. Rowling",Categoria = "Fantasia",AñoLanzamiento = 1997,Precio=500,idLibro=2,FotoId=101,FotoRuta="101.jpg"},
            new Libro(){Titulo = "Boca una pasion",Autor = "Carlos Tevez",Categoria = "Biografia",AñoLanzamiento = 2015,Precio=750,idLibro=3,FotoId=102,FotoRuta="102.jpg"},
            new Libro(){Titulo = "Los juegos del hambre",Autor = "Suzanne Collins",Categoria = "Fantasia",AñoLanzamiento = 2008,Precio=375,idLibro=4,FotoId=103,FotoRuta="103.jpg"},
            new Libro(){Titulo = "Don Quijote de la Mancha",Autor = "Miguel de Cervantes",Categoria = "Satira",AñoLanzamiento = 1605,Precio=450,idLibro=5,FotoId=104,FotoRuta="104.jpg"},
            new Libro(){Titulo = "Las mil y una noches",Autor = "Anonimo",Categoria = "Relato",AñoLanzamiento = 1500,Precio=650,idLibro=6,FotoId=105,FotoRuta="105.jpg"},
            new Libro(){Titulo = "Divina comedia",Autor = "Dante Alighieri",Categoria = "Epopeya",AñoLanzamiento = 1265,Precio=1250,idLibro=7,FotoId=106,FotoRuta="106.jpg"},
            new Libro(){Titulo = "Orgullo y prejuicio",Autor = "Jane Austen",Categoria = "Drama",AñoLanzamiento = 1813,Precio=2500,idLibro=8,FotoId=107,FotoRuta="107.jpg"},
            new Libro(){Titulo = "El viejo y el mar",Autor = "Ernest Hemingway",Categoria = "Novela",AñoLanzamiento = 1952,Precio=1125,idLibro=9,FotoId=108,FotoRuta="108.jpg"},
            new Libro(){Titulo = "Hamlet",Autor = "William Shakespeare",Categoria = "Drama ",AñoLanzamiento =  1603,Precio=3999,idLibro=10,FotoId=109,FotoRuta="109.jpg"}
        };


        //Categorias

        static List<Categoria> Categorias = new List<Categoria>()
        {
            new Categoria(){Id=20,Nombre="Aventuras"},
            new Categoria(){Id=21,Nombre="Cuento"},
            new Categoria(){Id=22,Nombre="Ciencia Ficción"},
            new Categoria(){Id=23,Nombre="Policíaca"},
            new Categoria(){Id=24,Nombre="Romántica"},
            new Categoria(){Id=25,Nombre="Teatro"}

        };


        //Busqueda




        //Listado Paginado
        public IActionResult ListadoPaginado(string campobusqueda, int? pagina)
        {

            var resultadobusqueda = Lista;

            if (!String.IsNullOrEmpty(campobusqueda))
            {
                resultadobusqueda = Lista
                    .Where(
                        X => X.Titulo.ToUpper().Contains(campobusqueda.ToUpper())
                     || X.Autor.ToUpper().Contains(campobusqueda.ToUpper())
                    )
                    .ToList<Libro>();
            }

            var listapaginada = Paginar(resultadobusqueda, pagina);

            return View(listapaginada);
        }

        private IPagedList Paginar(List<Libro> lista, int? pagina)
        {
            int pageSize = 4;
            int pageNumber = (pagina ?? 1);
            return lista.ToPagedList(pageNumber, pageSize);
        }


        //Listado

        public IActionResult Listar()
        {
            return View(Lista);
        }

        //Listado por Orden

        public IActionResult ListadoOrden(string ordenpor)
        {
            var ListaOrdenada = Lista;

            switch (ordenpor)
            {
                case "ordenporTitulo":
                    ListaOrdenada = Lista.OrderBy(x => x.Titulo).ToList<Libro>();
                    break;

                case "ordenporAutor":
                    ListaOrdenada = Lista.OrderBy(x => x.Autor).ToList<Libro>();
                    break;

                case "ordenporAño":
                    ListaOrdenada = Lista.OrderBy(x => x.AñoLanzamiento).ToList<Libro>();
                    break;

                case "ordenporCategoria":
                    ListaOrdenada = Lista.OrderBy(x => x.Categoria).ToList<Libro>();
                    break;

                case "ordenporPrecio":
                    ListaOrdenada = Lista.OrderBy(x => x.Precio).ToList<Libro>();
                    break;

            }



            return View(ListaOrdenada);
        }


        //Editar

        public IActionResult Editar(int idLibro)
        {
            var libro1 = Lista.Where(x => x.idLibro == idLibro).FirstOrDefault();
            return View(libro1);
        }


        //Editar => Accion

        [HttpPost]
        public IActionResult Editar(Libro formularioLibros)
        {
            if (ModelState.IsValid)
            {
                var infoLibro_Anterior = Lista.Where(x => x.idLibro == formularioLibros.idLibro).FirstOrDefault();
                Lista.Remove(infoLibro_Anterior);
                Lista.Add(formularioLibros);
                return RedirectToAction("Listar");
            }
            return View(formularioLibros);
        }




        //Controlador Historia Vista
        public IActionResult Historia()
        {
            return View();
        }

        //Nuevo

        public IActionResult Nuevo()
        {
            ViewBag.Categorias = Categorias;
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Libro formularioLibros)
        {

            if (formularioLibros.Foto != null)
            {
                string carpetaFotos = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                string nombrearchivo = formularioLibros.Foto.FileName;
                string rutaCompleta = Path.Combine(carpetaFotos, nombrearchivo);

                formularioLibros.Foto.CopyTo(new FileStream(rutaCompleta, FileMode.Create));
                formularioLibros.FotoRuta = nombrearchivo;
            }
            Lista.Add(formularioLibros);
            return RedirectToAction("ListadoPaginado");
        }

        public IActionResult Mostrar(int idLibro)
        {
            var libro = Lista.Where(x => x.idLibro == idLibro).FirstOrDefault();
            return View(libro);
        }

        public IActionResult Borrar(int idLibro)
        {
            var libro = Lista.Where(x => x.idLibro == idLibro).FirstOrDefault();
            Lista.Remove(libro);
            return RedirectToAction("Listar");
        }




    }

}