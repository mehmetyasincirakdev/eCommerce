using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


ProductTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var product in productManager.GetProductDetailDTOs())
    {
        Console.WriteLine(product.ProductName + " " + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var categories in categoryManager.GetAll())
    {
        Console.WriteLine(categories.CategoryName);
    }
}