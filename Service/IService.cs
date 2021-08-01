using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDoNet.Service
{
    public interface IService
    {

        void addProduct(produit produit);

        produit editProduct(int id,produit produit);

        void deleteProduct(int id);

        void addcategorie(categorie categorie);
        produit FindProductById(produit product);

        List<categorie> findAllCategories();
        List<produit> findAllProduit();

        categorie FindCategorieById(int id);

        void editCategorie(int id,categorie categorie);

        void removeCategorie(int idCat);

        List<produit> search(string denomination, string categorie, int? prixUnit, int? quantite);
    }
}
