using FanSoftStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanSoftStore.UI.Data
{
    public class DbInitializer
    {
        public static void Init(FanSoftStoreDataContext ctx)
        {
            ctx.Database.EnsureCreated();
            if (!ctx.Produtos.Any())
            {
                var produtos = new List<Produto>()
                {
                    new Produto{Nome= "Picanha", Tipo="Alimentação", Valor=49.99M},
                    new Produto{Nome= "Fralda", Tipo="Higiene", Valor=50.00M},
                    new Produto{Nome= "Pasta de Dentes", Tipo="Higiene", Valor=8.80M},
                    new Produto{Nome= "Iogurte", Tipo="Alimentação", Valor=11.10M},
                    new Produto{Nome= "Camisa Polo", Tipo="Vestuário", Valor=120.00M}
                };

                ctx.Produtos.AddRange(produtos);
                ctx.SaveChanges();
            }
        }
    }
}
