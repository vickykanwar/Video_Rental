using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public partial class Video_Rental : Form
    {
        classDB obj_Data = new classDB();
        public Video_Rental()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
            Popular_Cust_Load();
            Popular_Movie_Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Customer_Load()
        {
            customer_grid.DataSource = null;
            try
            {
                customer_grid.DataSource = obj_Data.FillCustomer_Data();
                customer_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void movie_Click(object sender, EventArgs e)
        {
        }

        public void Movies_Load()
        {
            movie_grid.DataSource = null;
            try
            {
                movie_grid.DataSource = obj_Data.FillMovies_Data();
                movie_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rental_Load()
        {
            rental_grid.DataSource = null;
            try
            {
                rental_grid.DataSource = obj_Data.FillRental_Data();
                rental_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void movie_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = movie_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                obj_Data.MovieID = Convert.ToInt32(movie_grid.Rows[e.RowIndex].Cells[0].Value);
                Rating_text.Text = movie_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                Tittle_text.Text = movie_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                Year_text.Text = movie_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                Rental_cost_text.Text = movie_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                Copies_text.Text = movie_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
                Plot_text.Text = movie_grid.Rows[e.RowIndex].Cells[6].Value.ToString();
                Genre_text.Text = movie_grid.Rows[e.RowIndex].Cells[7].Value.ToString();
                Movie_name_text.Text = movie_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                // code to show the message if user did not fill all the details
                MessageBox.Show("Something is wrong", ex.Message);
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_customer_btn_Click(object sender, EventArgs e)
        {
            if (First_name_text.Text != "" && Last_name_text.Text != "" && Address_text.Text != "" && Phone_text.Text != "")
            {
                string message = obj_Data.CustomerInsert(First_name_text.Text, Last_name_text.Text, Address_text.Text, Phone_text.Text);
                MessageBox.Show(message);
                First_name_text.Text = "";
                Last_name_text.Text = "";
                Address_text.Text = "";
                Phone_text.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please complete all the text boxes and then press Add button");

            }
        }

        private void Update_customer_btn_Click(object sender, EventArgs e)
        {
            if (First_name_text.Text != "" && Last_name_text.Text != "" && Address_text.Text != "" && Phone_text.Text != "")
            {
                string message = obj_Data.CustomerUpdate(First_name_text.Text, Last_name_text.Text, Address_text.Text, Phone_text.Text);
                MessageBox.Show(message);
                First_name_text.Text = "";
                Last_name_text.Text = "";
                Address_text.Text = "";
                Phone_text.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please complete all the text boxes and then press Add button");



            }
        }

        private void panelRental_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Issue_Movie_rental_btn_Click(object sender, EventArgs e)
        {
            if (Movie_name_text.Text != "" && Customer_name_text.Text != "")
            {
                string message = obj_Data.IssueMovie(Convert.ToDateTime(DateTime_rented_text.Text));
                MessageBox.Show(message);
                Rating_text.Text = "";
                Tittle_text.Text = "";
                Year_text.Text = "";
                Rental_cost_text.Text = "";
                Copies_text.Text = "";
                Plot_text.Text = "";
                Genre_text.Text = "";
                Movie_name_text.Text = "";
                First_name_text.Text = "";
                Last_name_text.Text = "";
                Address_text.Text = "";
                Phone_text.Text = "";
                Customer_name_text.Text = "";
                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please put sufficient data and add new details by clicking on Add button");
            }
        }

        private void customer_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = customer_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                obj_Data.CustomerID = Convert.ToInt32(customer_grid.Rows[e.RowIndex].Cells[0].Value);
                First_name_text.Text = customer_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                Last_name_text.Text = customer_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                Phone_text.Text = customer_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                Address_text.Text = customer_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                Customer_name_text.Text = customer_grid.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + customer_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                // code to show the message if user did not fill all the details
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }

        private void Return_Movie_renatl_btn_Click(object sender, EventArgs e)
        {
            if (Movie_name_text.Text != "" && Customer_name_text.Text != "")
            {
                string message = obj_Data.ReturnMovie(Convert.ToDateTime(DateTime_returned_text.Text));
                MessageBox.Show(message);
                Rating_text.Text = "";
                Tittle_text.Text = "";
                Year_text.Text = "";
                Rental_cost_text.Text = "";
                Copies_text.Text = "";
                Plot_text.Text = "";
                Genre_text.Text = "";
                Movie_name_text.Text = "";
                First_name_text.Text = "";
                Last_name_text.Text = "";
                Phone_text.Text = "";
                Address_text.Text = "";
                Customer_name_text.Text = "";
                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please put sufficient data and add new details by clicking on Add button");
            }
        }

        private void Delete_customer_btn_Click(object sender, EventArgs e)
        {
            string message = obj_Data.CustomerDelete();
            MessageBox.Show(message);
            First_name_text.Text = "";
            Last_name_text.Text = "";
            Phone_text.Text = "";
            Address_text.Text = "";
            Customer_name_text.Text = "";
            Customer_Load();
        }

        private void Add_movie_btn_Click(object sender, EventArgs e)
        {

            if (Rating_text.Text != "" && Tittle_text.Text != "" && Year_text.Text != "" && Rental_cost_text.Text != "" && Copies_text.Text != "" && Plot_text.Text != "" && Genre_text.Text != "")
           
            {
                string message = obj_Data.MovieInsert(Rating_text.Text, Tittle_text.Text, Year_text.Text, Rental_cost_text.Text, Copies_text.Text, Plot_text.Text, Genre_text.Text);

                MessageBox.Show(message);
                Rating_text.Text = "";
                Tittle_text.Text = "";
                Year_text.Text = "";
                Rental_cost_text.Text = "";
                Copies_text.Text = "";
                Plot_text.Text = "";
                Genre_text.Text = "";
                Movies_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please put sufficient data and add new details by clicking on Add button");
            }
        }
    

        public void Popular_Cust_Load()
        {
            popuCust_dgv.DataSource = null;
            try
            {
                popuCust_dgv.DataSource = obj_Data.FillPopuCustomer();
                popuCust_dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        public void Popular_Movie_Load()
        {
            popuMovie_dgv.DataSource = null;
            try
            {
                popuMovie_dgv.DataSource = obj_Data.FillPopular_Movie();
                popuMovie_dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_movie_btn_Click(object sender, EventArgs e)
        {

            if (Rating_text.Text != "" && Tittle_text.Text != "" && Year_text.Text != "" && Rental_cost_text.Text != "" && Copies_text.Text != "" && Plot_text.Text != "" && Genre_text.Text != "")
            {
                string message = obj_Data.MovieUpdate(Rating_text.Text, Tittle_text.Text, Year_text.Text, Rental_cost_text.Text, Copies_text.Text, Plot_text.Text, Genre_text.Text);
                MessageBox.Show(message);
                Rating_text.Text = "";
                Tittle_text.Text = "";
                Year_text.Text = "";
                Rental_cost_text.Text = "";
                Copies_text.Text = "";
                Plot_text.Text = "";
                Genre_text.Text = "";
                Movies_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please put sufficient data and add new details by clicking on Add button");
            }

        }

        private void Delete_movie_btn_Click(object sender, EventArgs e)
        {
            string message = obj_Data.MovieDelete();
            MessageBox.Show(message);
            Rating_text.Text = "";
            Tittle_text.Text = "";
            Year_text.Text = "";
            Rental_cost_text.Text = "";
            Copies_text.Text = "";
            Plot_text.Text = "";
            Genre_text.Text = "";
            Movie_name_text.Text = "";
            Movies_Load();
        }

        private void popuMovie_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allRented_button_Click(object sender, EventArgs e)
        {
            Rental_Load();
        }

        private void rentedOut_button_Click(object sender, EventArgs e)
        {
            rental_grid.DataSource = null;
            try
            {
                rental_grid.DataSource = obj_Data.RentedOut_Data();
                rental_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}   

