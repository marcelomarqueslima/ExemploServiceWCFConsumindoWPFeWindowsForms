using System;
using System.Linq;

namespace WcfServiceCategoria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string getCategoria(int id)
        {
            string Saida = "";

            try
            {
                localdbEntities context = new localdbEntities();
                Categorias categoria = context.Categorias.Single
                                  (a => a.Id == id);
                Saida = categoria.Categoria;
            }
            catch {
                Saida = "Não existe";
            }
            return Saida;
        }

        public string EditCategoria(int id, string value)
        {
            localdbEntities context = new localdbEntities();
            Categorias categoria = (from a in context.Categorias
                                    where a.Id == id
                                    select a).First();
            categoria.Categoria = value;
            context.SaveChanges();
            return "Categoria alterada";
        }

        public string DeleteCategoria(int id)
        {
            string Saida = "";

            try
            {
                localdbEntities context = new localdbEntities();
                Categorias categoria = context.Categorias.Single
                               (a => a.Id == id);
                context.Categorias.Remove(categoria);
                context.SaveChanges();
            }
            catch
            {
                Saida = "Não Existe";
            }
            return Saida;
        }

        public string CriarCategoria(string value)
        {
            localdbEntities context = new localdbEntities();
            Categorias categoria = new Categorias();
            categoria.Categoria = value;
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return string.Format("Nova Categoria");
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
