using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDoNet.Service
{
    public class ServiceImp : IService
    {
        private soko_produit_exam_donetEntities db = null;

        public ServiceImp()
        {
            db = new soko_produit_exam_donetEntities();
        }


        public void addcategorie(categorie categorie)
        {
          
            db.categorie.Add(categorie);
            db.SaveChanges();
        }

        public void addProduct(produit produit)
        {
            db.produit.Add(produit);
            db.SaveChanges();
        }

        public void deleteProduct(int id)
        {
            var produit = db.produit.Find(id);
            if(produit != null)
            {
                db.produit.Remove(produit);
                db.SaveChanges();
            }
         
        }

        public produit editProduct(int id,produit produit)
        {
            var product = db.produit.Find(id);

                product.PUProduit = produit.PUProduit;
                product.categorieProduit = produit.categorieProduit;
                product.denominationProduit = produit.denominationProduit;
                product.quantiteProduit = produit.quantiteProduit;

            db.SaveChanges();
           return product;
        }

        public List<categorie> findAllCategories()
        {
           return db.categorie.ToList();
        }

        public List<produit> findAllProduit()
        {
            return db.produit.ToList();
        }

        public produit FindProductById(produit product)
        {
            return db.produit.Find(product);
        }

        public categorie FindCategorieById(int id)
        {
            return db.categorie.Find(id);
        }


        public void editCategorie(int id, categorie categorie)
        {
            var catInDb = db.categorie.Find(id);
            if(catInDb != null)
            {
                catInDb.nomCat = categorie.nomCat;
                db.SaveChanges();
            }
       
           
        }

        public void removeCategorie(int idCat)
        {
            var catInDb = db.categorie.Find(idCat);
            if (catInDb != null)
            {
                db.categorie.Remove(catInDb);
            }
            db.SaveChanges();

        }


        public List<produit> search(string denomination,string categorie,int? prixUnit,int? quantite)
        {

            string sql = "SELECT * FROM produit";
            if (!denomination.Equals(""))
            {
                sql.Concat(" WHERE denominationProduit = " + denomination);
            }
            if (quantite > -1)
            {
                if (!sql.EndsWith("WHERE"))
                {
                    sql.Concat(" AND quantiteProduit = " + quantite);
                }
                else
                {
                    sql.Concat(" WHERE quantiteProduit = " + quantite);
                }
               
            }
            if(prixUnit > -1)
            {
                if (!sql.EndsWith("WHERE"))
                {
                    sql.Concat(" AND PUProduit = " + prixUnit);
                }
                else
                {
                    sql.Concat(" WHERE PUProduit = " + prixUnit);
                }
                   
            }
            if (categorie != null)
            {
                if (!sql.EndsWith("WHERE"))
                {
                    sql.Concat(" AND categorieProduit = " + categorie);
                }
                else
                {
                    sql.Concat(" WHERE categorieProduit = " + categorie);
                }
                    
            }

            return db.produit.SqlQuery(sql).ToList();
        }
    }
}
