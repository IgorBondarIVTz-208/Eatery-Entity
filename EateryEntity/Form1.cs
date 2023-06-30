using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EateryEntity
{
    public partial class Root : Form
    {

        private EateryEntities dbContext;
        public Root()
        {
            InitializeComponent();
            dbContext = new EateryEntities();
            ProductsView.CellEndEdit += productsEdit;
            PurchasesView.CellEndEdit += purchasesEdit;
            dishesView.CellEndEdit += dishEdit;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        [Serializable]
        public class ProductsViewModel
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public double Price { get; set; }
        }


        private void UpdateProducts()
        {
            var products = dbContext.Product.Select(x => new ProductsViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,

            }).ToList();
            ProductsView.DataSource = products;
            ProductsView.Columns["Id"].ReadOnly = true;
        }

        private void productsUpdateClick(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void productsEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Получить индекс редактируемой ячейки
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Получить значение, введенное пользователем
            object editedValue = ProductsView.Rows[rowIndex].Cells[columnIndex].Value;
            int id = Convert.ToInt32(ProductsView.Rows[rowIndex].Cells[0].Value);
            Console.WriteLine(id);

            // Выполнить необходимые действия с измененным значением

            // Например, обновить базу данных с использованием Entity Framework
            // Получить объект данных из выбранной строки
            var product = dbContext.Product.Find(id);

            // Обновить соответствующее свойство объекта данных
            switch (columnIndex)
            {
                case 1:
                    product.Name = editedValue.ToString();
                    break;
                case 2:
                    product.Price = Convert.ToDouble(editedValue);
                    break;
                    // Добавьте обработку других столбцов, если необходимо
            }


            // Обновить объект данных в контексте
            dbContext.Entry(product).State = EntityState.Modified;

            saveBD();
     
            UpdateProducts();

        }

        private void productDelete_Click(object sender, EventArgs e)
        {
            // Проверка, есть ли выбранная строка в DataGridView
            if (ProductsView.SelectedRows.Count > 0)
            {
                // Получение выбранной строки
                DataGridViewRow selectedRow = ProductsView.SelectedRows[0];
                int id = Convert.ToInt32(ProductsView.Rows[selectedRow.Index].Cells[0].Value);
                var product = dbContext.Product.Find(id);

                // Удаление объекта данных из контекста
                dbContext.Product.Remove(product);

                // Сохранение изменений
                saveBD();

                UpdateProducts();
            }

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            // Создаете новый объект Product с полученными данными
            var newProduct = new Product
            {
                Name = "Новый продукт",
                Price = 0
            };

            // Добавляете новый продукт в базу данных через контекст Entity Framework
            dbContext.Product.Add(newProduct);
            saveBD();

            UpdateProducts();
        }
        [Serializable]
        public class PurchaseViewModel
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public int ProductId { get; set; }
            public string Product { get; set; }

            public double Quanty { get; set; }
        }

        private void UpdatePurchasesF()
        {
            var purchases = dbContext.Purchase.Select(x => new PurchaseViewModel
            {
                Id = x.Id,
                Date = x.Date,
                ProductId = x.ProductId,
                Product = x.Product.Name,
                Quanty = x.Quanty ?? 0.0
            }).ToList();
            // Привязываем список данных к DataGridView
            PurchasesView.DataSource = purchases;
            PurchasesView.Columns["Id"].ReadOnly = true;
            PurchasesView.Columns["Product"].ReadOnly = true;
        }

        private void UpdatePurchases_Click(object sender, EventArgs e)
        {
            UpdatePurchasesF();
        }

        private void RemovePurchases_Click(object sender, EventArgs e)
        {
            // Проверка, есть ли выбранная строка в DataGridView
            if (PurchasesView.SelectedRows.Count > 0)
            {
                // Получение выбранной строки
                DataGridViewRow selectedRow = PurchasesView.SelectedRows[0];

                int id = Convert.ToInt32(PurchasesView.Rows[selectedRow.Index].Cells[0].Value);
                var purchase = dbContext.Purchase.Find(id);
                // Получение объекта данных из выбранной строки
                //var purchase = selectedRow.DataBoundItem as Purchase;

                // Удаление объекта данных из контекста
                dbContext.Purchase.Remove(purchase);

                // Сохранение изменений
                saveBD();

                UpdatePurchasesF();
            }
        }

        private void AddPurchases_Click(object sender, EventArgs e)
        {
            var products = dbContext.Product.ToList();
            if(products.Count == 0)
            {
                return;
            }

            // Создаете новый объект Product с полученными данными
            var newPurchase = new Purchase
            {
                Date = DateTime.Now,
                ProductId = products[0].Id,
                Quanty = 0.0
            };

            // Добавляете новый продукт в базу данных через контекст Entity Framework
            dbContext.Purchase.Add(newPurchase);
            saveBD();

            UpdatePurchasesF();
        }

        private void purchasesEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Получить индекс редактируемой ячейки
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            Console.WriteLine(columnIndex);

            // Получить значение, введенное пользователем
            object editedValue = PurchasesView.Rows[rowIndex].Cells[columnIndex].Value;
            int id = Convert.ToInt32(PurchasesView.Rows[rowIndex].Cells[0].Value);
            Console.WriteLine(editedValue);

            // Выполнить необходимые действия с измененным значением

            // Например, обновить базу данных с использованием Entity Framework
            // Получить объект данных из выбранной строки
            var purchase = dbContext.Purchase.Find(id);

            // Обновить соответствующее свойство объекта данных
            switch (columnIndex)
            {
                case 1:
                    purchase.Date = DateTime.Parse(editedValue.ToString());
                    break;
                case 2:
                    purchase.ProductId = Convert.ToInt32(editedValue);
                    break;
                case 4:
                    purchase.Quanty = Convert.ToDouble(editedValue);
                    break;
            }


            // Обновить объект данных в контексте
            dbContext.Entry(purchase).State = EntityState.Modified;
            saveBD();

            UpdatePurchasesF();

        }

        private void Root_Load(object sender, EventArgs e)
        {
            UpdateProducts();
            UpdateDishes();
            UpdatePurchasesF();
        }

        [Serializable]
        public class DishViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public List<int> ProductsIdList { get; set; }

            public string ProductsId { get; set; }

            public List<String> ProductsNamesList { get; set; }

            public string ProductsNames { get; set; }

            //public string ProductsNames { get; set; }
        }

        private void UpdateDishes()
        {
            var dishes = dbContext.DishSet.Select(x => new DishViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ProductsIdList = x.Product.Select(p => p.Id).ToList(),
                ProductsNamesList = x.Product.Select(p => p.Name).ToList(),
            }).ToList();

            dishes.ForEach(p => p.ProductsId = string.Join(",", p.ProductsIdList));
            dishes.ForEach(p => p.ProductsNames = string.Join(",", p.ProductsNamesList));
            // Привязываем список данных к DataGridView
            dishesView.DataSource = dishes;

            dishesView.Columns["ProductsNames"].ReadOnly = true;
            dishesView.Columns["Id"].ReadOnly = true;
        }

        private void UpdateDishBtn_Click(object sender, EventArgs e)
        {
            UpdateDishes();
        }

        private void RemoveDishes_Click(object sender, EventArgs e)
        {
            // Проверка, есть ли выбранная строка в DataGridView
            if (dishesView.SelectedRows.Count > 0)
            {
                // Получение выбранной строки
                DataGridViewRow selectedRow = dishesView.SelectedRows[0];

                int id = Convert.ToInt32(dishesView.Rows[selectedRow.Index].Cells[0].Value);
                var dish = dbContext.DishSet.Find(id);

                // Удаление объекта данных из контекста
                dbContext.DishSet.Remove(dish);

                saveBD();

                UpdateDishes();
            }
        }

        private void AddDish_Click(object sender, EventArgs e)
        {
            var newDish = new DishSet
            {
                Name = "Новое блюдо",
            };
            newDish.Product.Add(dbContext.Product.ToList()[0]);

            // Добавляете новый продукт в базу данных через контекст Entity Framework
            dbContext.DishSet.Add(newDish);
            dbContext.SaveChanges();

            UpdateDishes();
        }
        private void dishEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Получить индекс редактируемой ячейки
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            Console.WriteLine(columnIndex);

            // Получить значение, введенное пользователем
            object editedValue = dishesView.Rows[rowIndex].Cells[columnIndex].Value;
            int id = Convert.ToInt32(dishesView.Rows[rowIndex].Cells[0].Value);
            Console.WriteLine(editedValue);

            // Выполнить необходимые действия с измененным значением

            // Например, обновить базу данных с использованием Entity Framework
            // Получить объект данных из выбранной строки
            var dish = dbContext.DishSet.Find(id);

            // Обновить соответствующее свойство объекта данных
            switch (columnIndex)
            {
                case 1:
                    dish.Name = editedValue.ToString();
                    break;
                case 2:
                    bool norm = true;
                    dish.Product.Clear();

                    string[] productIdsArray = editedValue.ToString().Split(',');
                    foreach (string productIdStr in productIdsArray)
                    {
                        if (int.TryParse(productIdStr, out int productId))
                        {
                            Product product = dbContext.Product.Find(productId);
                            if (product != null)
                            {
                                dish.Product.Add(product);
                            }
                            else
                            {
                                norm = false;
                                // Показать окно с сообщением об ошибке
                                MessageBox.Show("Произошла ошибка при поиске продукта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            norm = false;
                            // Показать окно с сообщением об ошибке
                            MessageBox.Show("Произошла ошибка при получении id из строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }


            // Обновить объект данных в контексте
            dbContext.Entry(dish).State = EntityState.Modified;
            saveBD();

            UpdateDishes();

        }

        private void saveBD()
        {
            try
            {
                // Сохранить изменения
                dbContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Обработка исключения DbUpdateException
                string errorMessage = "Произошла ошибка при сохранении изменений в базе данных.";

                // Показать окно с сообщением об ошибке
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   
}
