using WorkstationShopLibrary;

namespace WorkstationShop
{
    public partial class Form1 : Form
    {
        //create an instance of a personalized store
        Store myStore = new Store();

        //binds and associates the lists together 
        BindingSource shoppingListInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private ComboBox GetTxt_type()
        {
            return txt_type;
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            //get the selected item from the inventory
            Workstation selected = (Workstation) lst_inventory.SelectedItem;

            //add that item to the cart
            myStore.ShoppingList.Add(selected);
            
            //update the list box
            cartBindingSource.ResetBindings(false);

            
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$" + total.ToString();

            cartBindingSource.ResetBindings(false);
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*a switch to read the item properties and create an item
        // create instances of each object
        //
        //
        */
        private void btn_create_item_Click(object sender, EventArgs e)
        {
            switch (txt_type.Text)
            {
                case "Desk":
                    Desk newDesk = new Desk(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newDesk.Type + ", " + newDesk.Company + ", " + newDesk.Model + ", $" + newDesk.Price);
                    myStore.ShoppingList.Add(newDesk);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                case "Chair":
                    Chair newChair = new Chair(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newChair.Type + ", " + newChair.Company + ", " + newChair.Model + ", $" + newChair.Price);
                    myStore.ShoppingList.Add(newChair);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                case "Deskpad":
                    Deskpad newDeskpad = new Deskpad(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newDeskpad.Type + ", " + newDeskpad.Company + ", " + newDeskpad.Model + ", $" + newDeskpad.Price);
                    myStore.ShoppingList.Add(newDeskpad);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                case "Desklamp":
                    DeskLamp newLamp = new DeskLamp(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newLamp.Type + ", " + newLamp.Company + ", " + newLamp.Model + ", $" + newLamp.Price);
                    myStore.ShoppingList.Add(newLamp);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                case "Headphones":
                    Headphones newHeadphones = new Headphones(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newHeadphones.Type + ", " + newHeadphones.Company + ", " + newHeadphones.Model + ", $" + newHeadphones.Price);
                    myStore.ShoppingList.Add(newHeadphones);
                    shoppingListInventoryBindingSource.ResetBindings(false); 
                    break;
                case "Keyboard":
                    Keyboard newKeyboard = new Keyboard(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newKeyboard.Type + ", " + newKeyboard.Company + ", " + newKeyboard.Model + ", $" + newKeyboard.Price);
                    myStore.ShoppingList.Add(newKeyboard);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                case "Mouse":
                    Mouse newMouse = new Mouse(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newMouse.Type + ", " + newMouse.Company + ", " + newMouse.Model + ", $" + newMouse.Price);
                    myStore.ShoppingList.Add(newMouse);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                case "Monitor":
                    CodeMonitor newMonitor = new CodeMonitor(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newMonitor.Type + ", " + newMonitor.Company + ", " + newMonitor.Model + ", $" + newMonitor.Price);
                    myStore.ShoppingList.Add(newMonitor);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                case "Water Bottle":
                    WaterBottle newBottle = new WaterBottle(txt_type.Text, decimal.Parse(txt_price.Text), txt_model.Text, txt_company.Text);
                    MessageBox.Show(newBottle.Type + ", " + newBottle.Company + ", " + newBottle.Model + ", $" + newBottle.Price);
                    myStore.ShoppingList.Add(newBottle);
                    shoppingListInventoryBindingSource.ResetBindings(false);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shoppingListInventoryBindingSource.DataSource = myStore.ShoppingList;

            cartBindingSource.DataSource = myStore.ShoppingList;

            lst_inventory.DataSource = shoppingListInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }
    }
}