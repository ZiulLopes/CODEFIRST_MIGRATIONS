using CODEFIRST_MIGRATIONS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_MIGRATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * enable-migrations        -> 1X PARA INICIAR A MIGRATION
             * add-migration "inicial"
             * update-database
             */

            var dbContext = new DataContext();
            var filmes = dbContext.FILME.ToList();

            foreach (var filme in filmes)
            {
                Console.WriteLine(filme.NOMEFILME);
            }

            dbContext.FILME.Add(null);
            dbContext.SaveChanges();

            Console.WriteLine("Working...");
            Console.ReadKey();
        }

        public void Deletar(FILME filme)
        {
            var dbContext = new DataContext();

            dbContext.FILME.Remove(filme);
        }

        public void Editar(FILME filme)
        {
            var dbContext = new DataContext();
            var _filme = dbContext.FILME.ToList().Where(x => x.FILMEID == filme.FILMEID).FirstOrDefault();

            _filme.NOMEFILME = filme.NOMEFILME;
            _filme.ANOLANCAMENTO = filme.ANOLANCAMENTO;
            
            dbContext.SaveChanges();
        }
    }
}
