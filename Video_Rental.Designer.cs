namespace Video_Rental
{
    partial class Video_Rental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customertab = new System.Windows.Forms.TabControl();
            this.customer = new System.Windows.Forms.TabPage();
            this.customer_grid = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.movie = new System.Windows.Forms.TabPage();
            this.movie_grid = new System.Windows.Forms.DataGridView();
            this.rental = new System.Windows.Forms.TabPage();
            this.rental_grid = new System.Windows.Forms.DataGridView();
            this.tab_popularMovie = new System.Windows.Forms.TabPage();
            this.popuMovie_dgv = new System.Windows.Forms.DataGridView();
            this.tab_popuCust = new System.Windows.Forms.TabPage();
            this.popuCust_dgv = new System.Windows.Forms.DataGridView();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.Update_movie_btn = new System.Windows.Forms.Button();
            this.Delete_movie_btn = new System.Windows.Forms.Button();
            this.Add_movie_btn = new System.Windows.Forms.Button();
            this.Genre_text = new System.Windows.Forms.TextBox();
            this.Genre_label = new System.Windows.Forms.Label();
            this.Copies_text = new System.Windows.Forms.TextBox();
            this.Plot_text = new System.Windows.Forms.TextBox();
            this.Rental_cost_text = new System.Windows.Forms.TextBox();
            this.Plot_label = new System.Windows.Forms.Label();
            this.Copies_label = new System.Windows.Forms.Label();
            this.Rental_cost_label = new System.Windows.Forms.Label();
            this.Year_label = new System.Windows.Forms.Label();
            this.Year_text = new System.Windows.Forms.TextBox();
            this.Rating_text = new System.Windows.Forms.TextBox();
            this.Movie_features = new System.Windows.Forms.Label();
            this.Tittle_text = new System.Windows.Forms.TextBox();
            this.Tittle_label = new System.Windows.Forms.Label();
            this.Rating_label = new System.Windows.Forms.Label();
            this.panelRental = new System.Windows.Forms.Panel();
            this.DateTime_returned_text = new System.Windows.Forms.DateTimePicker();
            this.DateTime_rented_text = new System.Windows.Forms.DateTimePicker();
            this.Return_Movie_renatl_btn = new System.Windows.Forms.Button();
            this.Customer_name_text = new System.Windows.Forms.TextBox();
            this.Issue_Movie_rental_btn = new System.Windows.Forms.Button();
            this.Movie_name_text = new System.Windows.Forms.TextBox();
            this.Date_returned_label = new System.Windows.Forms.Label();
            this.Date_rented_label = new System.Windows.Forms.Label();
            this.Rental_features = new System.Windows.Forms.Label();
            this.Movie_name_label = new System.Windows.Forms.Label();
            this.Customer_name_label = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.Update_customer_btn = new System.Windows.Forms.Button();
            this.Delete_customer_btn = new System.Windows.Forms.Button();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.Add_customer_btn = new System.Windows.Forms.Button();
            this.Address_text = new System.Windows.Forms.TextBox();
            this.Last_name_text = new System.Windows.Forms.TextBox();
            this.First_name_label = new System.Windows.Forms.Label();
            this.First_name_text = new System.Windows.Forms.TextBox();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Last_name_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Customer_features = new System.Windows.Forms.Label();
            this.rentedOut_button = new System.Windows.Forms.Button();
            this.allRented_button = new System.Windows.Forms.Button();
            this.customertab.SuspendLayout();
            this.customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_grid)).BeginInit();
            this.movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_grid)).BeginInit();
            this.rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rental_grid)).BeginInit();
            this.tab_popularMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popuMovie_dgv)).BeginInit();
            this.tab_popuCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popuCust_dgv)).BeginInit();
            this.panelMovie.SuspendLayout();
            this.panelRental.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // customertab
            // 
            this.customertab.Controls.Add(this.customer);
            this.customertab.Controls.Add(this.movie);
            this.customertab.Controls.Add(this.rental);
            this.customertab.Controls.Add(this.tab_popularMovie);
            this.customertab.Controls.Add(this.tab_popuCust);
            this.customertab.Location = new System.Drawing.Point(441, 12);
            this.customertab.Name = "customertab";
            this.customertab.SelectedIndex = 0;
            this.customertab.Size = new System.Drawing.Size(423, 309);
            this.customertab.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.DarkKhaki;
            this.customer.Controls.Add(this.customer_grid);
            this.customer.Controls.Add(this.button5);
            this.customer.Location = new System.Drawing.Point(4, 22);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(3);
            this.customer.Size = new System.Drawing.Size(415, 283);
            this.customer.TabIndex = 0;
            this.customer.Text = "customer";
            // 
            // customer_grid
            // 
            this.customer_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customer_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_grid.Location = new System.Drawing.Point(6, 10);
            this.customer_grid.Name = "customer_grid";
            this.customer_grid.Size = new System.Drawing.Size(406, 267);
            this.customer_grid.TabIndex = 1;
            this.customer_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_grid_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // movie
            // 
            this.movie.BackColor = System.Drawing.Color.RosyBrown;
            this.movie.Controls.Add(this.movie_grid);
            this.movie.Location = new System.Drawing.Point(4, 22);
            this.movie.Name = "movie";
            this.movie.Padding = new System.Windows.Forms.Padding(3);
            this.movie.Size = new System.Drawing.Size(415, 283);
            this.movie.TabIndex = 1;
            this.movie.Text = "movie";
            this.movie.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie_grid
            // 
            this.movie_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.movie_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movie_grid.Location = new System.Drawing.Point(10, 6);
            this.movie_grid.Name = "movie_grid";
            this.movie_grid.Size = new System.Drawing.Size(399, 271);
            this.movie_grid.TabIndex = 0;
            this.movie_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movie_grid_CellContentClick);
            this.movie_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movie_grid_CellContentClick);
            // 
            // rental
            // 
            this.rental.BackColor = System.Drawing.Color.DarkCyan;
            this.rental.Controls.Add(this.rental_grid);
            this.rental.Location = new System.Drawing.Point(4, 22);
            this.rental.Name = "rental";
            this.rental.Padding = new System.Windows.Forms.Padding(3);
            this.rental.Size = new System.Drawing.Size(415, 283);
            this.rental.TabIndex = 2;
            this.rental.Text = "rental";
            // 
            // rental_grid
            // 
            this.rental_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rental_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rental_grid.Location = new System.Drawing.Point(6, 6);
            this.rental_grid.Name = "rental_grid";
            this.rental_grid.Size = new System.Drawing.Size(403, 271);
            this.rental_grid.TabIndex = 1;
            // 
            // tab_popularMovie
            // 
            this.tab_popularMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tab_popularMovie.Controls.Add(this.popuMovie_dgv);
            this.tab_popularMovie.Location = new System.Drawing.Point(4, 22);
            this.tab_popularMovie.Name = "tab_popularMovie";
            this.tab_popularMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tab_popularMovie.Size = new System.Drawing.Size(415, 283);
            this.tab_popularMovie.TabIndex = 3;
            this.tab_popularMovie.Text = "Popular Movies";
            // 
            // popuMovie_dgv
            // 
            this.popuMovie_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.popuMovie_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popuMovie_dgv.GridColor = System.Drawing.Color.Khaki;
            this.popuMovie_dgv.Location = new System.Drawing.Point(6, 6);
            this.popuMovie_dgv.Name = "popuMovie_dgv";
            this.popuMovie_dgv.Size = new System.Drawing.Size(403, 271);
            this.popuMovie_dgv.TabIndex = 1;
            this.popuMovie_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.popuMovie_dgv_CellContentClick);
            // 
            // tab_popuCust
            // 
            this.tab_popuCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab_popuCust.Controls.Add(this.popuCust_dgv);
            this.tab_popuCust.Location = new System.Drawing.Point(4, 22);
            this.tab_popuCust.Name = "tab_popuCust";
            this.tab_popuCust.Padding = new System.Windows.Forms.Padding(3);
            this.tab_popuCust.Size = new System.Drawing.Size(415, 283);
            this.tab_popuCust.TabIndex = 4;
            this.tab_popuCust.Text = "Popular Customer";
            // 
            // popuCust_dgv
            // 
            this.popuCust_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.popuCust_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popuCust_dgv.Location = new System.Drawing.Point(6, 6);
            this.popuCust_dgv.Name = "popuCust_dgv";
            this.popuCust_dgv.Size = new System.Drawing.Size(403, 271);
            this.popuCust_dgv.TabIndex = 0;
            // 
            // panelMovie
            // 
            this.panelMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMovie.Controls.Add(this.Update_movie_btn);
            this.panelMovie.Controls.Add(this.Delete_movie_btn);
            this.panelMovie.Controls.Add(this.Add_movie_btn);
            this.panelMovie.Controls.Add(this.Genre_text);
            this.panelMovie.Controls.Add(this.Genre_label);
            this.panelMovie.Controls.Add(this.Copies_text);
            this.panelMovie.Controls.Add(this.Plot_text);
            this.panelMovie.Controls.Add(this.Rental_cost_text);
            this.panelMovie.Controls.Add(this.Plot_label);
            this.panelMovie.Controls.Add(this.Copies_label);
            this.panelMovie.Controls.Add(this.Rental_cost_label);
            this.panelMovie.Controls.Add(this.Year_label);
            this.panelMovie.Controls.Add(this.Year_text);
            this.panelMovie.Controls.Add(this.Rating_text);
            this.panelMovie.Controls.Add(this.Movie_features);
            this.panelMovie.Controls.Add(this.Tittle_text);
            this.panelMovie.Controls.Add(this.Tittle_label);
            this.panelMovie.Controls.Add(this.Rating_label);
            this.panelMovie.Location = new System.Drawing.Point(38, 28);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(337, 332);
            this.panelMovie.TabIndex = 1;
            // 
            // Update_movie_btn
            // 
            this.Update_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Update_movie_btn.Location = new System.Drawing.Point(139, 290);
            this.Update_movie_btn.Name = "Update_movie_btn";
            this.Update_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_movie_btn.TabIndex = 25;
            this.Update_movie_btn.Text = "Update";
            this.Update_movie_btn.UseVisualStyleBackColor = false;
            this.Update_movie_btn.Click += new System.EventHandler(this.Update_movie_btn_Click);
            // 
            // Delete_movie_btn
            // 
            this.Delete_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete_movie_btn.Location = new System.Drawing.Point(249, 290);
            this.Delete_movie_btn.Name = "Delete_movie_btn";
            this.Delete_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_movie_btn.TabIndex = 24;
            this.Delete_movie_btn.Text = "Delete";
            this.Delete_movie_btn.UseVisualStyleBackColor = false;
            this.Delete_movie_btn.Click += new System.EventHandler(this.Delete_movie_btn_Click);
            // 
            // Add_movie_btn
            // 
            this.Add_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Add_movie_btn.Location = new System.Drawing.Point(27, 290);
            this.Add_movie_btn.Name = "Add_movie_btn";
            this.Add_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_movie_btn.TabIndex = 23;
            this.Add_movie_btn.Text = "Add";
            this.Add_movie_btn.UseVisualStyleBackColor = false;
            this.Add_movie_btn.Click += new System.EventHandler(this.Add_movie_btn_Click);
            // 
            // Genre_text
            // 
            this.Genre_text.Location = new System.Drawing.Point(207, 236);
            this.Genre_text.Name = "Genre_text";
            this.Genre_text.Size = new System.Drawing.Size(100, 20);
            this.Genre_text.TabIndex = 22;
            // 
            // Genre_label
            // 
            this.Genre_label.AutoSize = true;
            this.Genre_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Genre_label.Location = new System.Drawing.Point(18, 236);
            this.Genre_label.Name = "Genre_label";
            this.Genre_label.Size = new System.Drawing.Size(36, 13);
            this.Genre_label.TabIndex = 9;
            this.Genre_label.Text = "Genre";
            // 
            // Copies_text
            // 
            this.Copies_text.Location = new System.Drawing.Point(207, 168);
            this.Copies_text.Name = "Copies_text";
            this.Copies_text.Size = new System.Drawing.Size(100, 20);
            this.Copies_text.TabIndex = 20;
            // 
            // Plot_text
            // 
            this.Plot_text.Location = new System.Drawing.Point(207, 198);
            this.Plot_text.Name = "Plot_text";
            this.Plot_text.Size = new System.Drawing.Size(100, 20);
            this.Plot_text.TabIndex = 21;
            // 
            // Rental_cost_text
            // 
            this.Rental_cost_text.Location = new System.Drawing.Point(207, 134);
            this.Rental_cost_text.Name = "Rental_cost_text";
            this.Rental_cost_text.Size = new System.Drawing.Size(100, 20);
            this.Rental_cost_text.TabIndex = 19;
            // 
            // Plot_label
            // 
            this.Plot_label.AutoSize = true;
            this.Plot_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Plot_label.Location = new System.Drawing.Point(18, 201);
            this.Plot_label.Name = "Plot_label";
            this.Plot_label.Size = new System.Drawing.Size(25, 13);
            this.Plot_label.TabIndex = 4;
            this.Plot_label.Text = "Plot";
            // 
            // Copies_label
            // 
            this.Copies_label.AutoSize = true;
            this.Copies_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Copies_label.Location = new System.Drawing.Point(18, 168);
            this.Copies_label.Name = "Copies_label";
            this.Copies_label.Size = new System.Drawing.Size(39, 13);
            this.Copies_label.TabIndex = 8;
            this.Copies_label.Text = "Copies";
            // 
            // Rental_cost_label
            // 
            this.Rental_cost_label.AutoSize = true;
            this.Rental_cost_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Rental_cost_label.Location = new System.Drawing.Point(18, 134);
            this.Rental_cost_label.Name = "Rental_cost_label";
            this.Rental_cost_label.Size = new System.Drawing.Size(61, 13);
            this.Rental_cost_label.TabIndex = 4;
            this.Rental_cost_label.Text = "Rental cost";
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Year_label.Location = new System.Drawing.Point(18, 96);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(29, 13);
            this.Year_label.TabIndex = 7;
            this.Year_label.Text = "Year";
            // 
            // Year_text
            // 
            this.Year_text.Location = new System.Drawing.Point(207, 96);
            this.Year_text.Name = "Year_text";
            this.Year_text.Size = new System.Drawing.Size(100, 20);
            this.Year_text.TabIndex = 18;
            // 
            // Rating_text
            // 
            this.Rating_text.Location = new System.Drawing.Point(207, 25);
            this.Rating_text.Name = "Rating_text";
            this.Rating_text.Size = new System.Drawing.Size(100, 20);
            this.Rating_text.TabIndex = 16;
            // 
            // Movie_features
            // 
            this.Movie_features.AutoSize = true;
            this.Movie_features.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Movie_features.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_features.Location = new System.Drawing.Point(90, 4);
            this.Movie_features.Name = "Movie_features";
            this.Movie_features.Size = new System.Drawing.Size(127, 20);
            this.Movie_features.TabIndex = 0;
            this.Movie_features.Text = "Movie features";
            // 
            // Tittle_text
            // 
            this.Tittle_text.Location = new System.Drawing.Point(207, 61);
            this.Tittle_text.Name = "Tittle_text";
            this.Tittle_text.Size = new System.Drawing.Size(100, 20);
            this.Tittle_text.TabIndex = 17;
            // 
            // Tittle_label
            // 
            this.Tittle_label.AutoSize = true;
            this.Tittle_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tittle_label.Location = new System.Drawing.Point(18, 61);
            this.Tittle_label.Name = "Tittle_label";
            this.Tittle_label.Size = new System.Drawing.Size(30, 13);
            this.Tittle_label.TabIndex = 6;
            this.Tittle_label.Text = "Tittle";
            // 
            // Rating_label
            // 
            this.Rating_label.AutoSize = true;
            this.Rating_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Rating_label.Location = new System.Drawing.Point(18, 28);
            this.Rating_label.Name = "Rating_label";
            this.Rating_label.Size = new System.Drawing.Size(38, 13);
            this.Rating_label.TabIndex = 5;
            this.Rating_label.Text = "Rating";
            // 
            // panelRental
            // 
            this.panelRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelRental.Controls.Add(this.DateTime_returned_text);
            this.panelRental.Controls.Add(this.DateTime_rented_text);
            this.panelRental.Controls.Add(this.Return_Movie_renatl_btn);
            this.panelRental.Controls.Add(this.Customer_name_text);
            this.panelRental.Controls.Add(this.Issue_Movie_rental_btn);
            this.panelRental.Controls.Add(this.Movie_name_text);
            this.panelRental.Controls.Add(this.Date_returned_label);
            this.panelRental.Controls.Add(this.Date_rented_label);
            this.panelRental.Controls.Add(this.Rental_features);
            this.panelRental.Controls.Add(this.Movie_name_label);
            this.panelRental.Controls.Add(this.Customer_name_label);
            this.panelRental.Location = new System.Drawing.Point(38, 391);
            this.panelRental.Name = "panelRental";
            this.panelRental.Size = new System.Drawing.Size(372, 260);
            this.panelRental.TabIndex = 2;
            this.panelRental.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRental_Paint);
            // 
            // DateTime_returned_text
            // 
            this.DateTime_returned_text.Location = new System.Drawing.Point(154, 180);
            this.DateTime_returned_text.Name = "DateTime_returned_text";
            this.DateTime_returned_text.Size = new System.Drawing.Size(200, 20);
            this.DateTime_returned_text.TabIndex = 31;
            this.DateTime_returned_text.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // DateTime_rented_text
            // 
            this.DateTime_rented_text.Location = new System.Drawing.Point(154, 142);
            this.DateTime_rented_text.Name = "DateTime_rented_text";
            this.DateTime_rented_text.Size = new System.Drawing.Size(200, 20);
            this.DateTime_rented_text.TabIndex = 30;
            // 
            // Return_Movie_renatl_btn
            // 
            this.Return_Movie_renatl_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Return_Movie_renatl_btn.Location = new System.Drawing.Point(154, 222);
            this.Return_Movie_renatl_btn.Name = "Return_Movie_renatl_btn";
            this.Return_Movie_renatl_btn.Size = new System.Drawing.Size(108, 23);
            this.Return_Movie_renatl_btn.TabIndex = 28;
            this.Return_Movie_renatl_btn.Text = "Return Movie";
            this.Return_Movie_renatl_btn.UseVisualStyleBackColor = false;
            this.Return_Movie_renatl_btn.Click += new System.EventHandler(this.Return_Movie_renatl_btn_Click);
            // 
            // Customer_name_text
            // 
            this.Customer_name_text.Location = new System.Drawing.Point(198, 92);
            this.Customer_name_text.Name = "Customer_name_text";
            this.Customer_name_text.Size = new System.Drawing.Size(100, 20);
            this.Customer_name_text.TabIndex = 10;
            // 
            // Issue_Movie_rental_btn
            // 
            this.Issue_Movie_rental_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Issue_Movie_rental_btn.Location = new System.Drawing.Point(27, 222);
            this.Issue_Movie_rental_btn.Name = "Issue_Movie_rental_btn";
            this.Issue_Movie_rental_btn.Size = new System.Drawing.Size(75, 23);
            this.Issue_Movie_rental_btn.TabIndex = 26;
            this.Issue_Movie_rental_btn.Text = "Issue Movie";
            this.Issue_Movie_rental_btn.UseVisualStyleBackColor = false;
            this.Issue_Movie_rental_btn.Click += new System.EventHandler(this.Issue_Movie_rental_btn_Click);
            // 
            // Movie_name_text
            // 
            this.Movie_name_text.Location = new System.Drawing.Point(198, 50);
            this.Movie_name_text.Name = "Movie_name_text";
            this.Movie_name_text.Size = new System.Drawing.Size(100, 20);
            this.Movie_name_text.TabIndex = 4;
            // 
            // Date_returned_label
            // 
            this.Date_returned_label.AutoSize = true;
            this.Date_returned_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Date_returned_label.Location = new System.Drawing.Point(24, 186);
            this.Date_returned_label.Name = "Date_returned_label";
            this.Date_returned_label.Size = new System.Drawing.Size(72, 13);
            this.Date_returned_label.TabIndex = 4;
            this.Date_returned_label.Text = "Date returned";
            // 
            // Date_rented_label
            // 
            this.Date_rented_label.AutoSize = true;
            this.Date_rented_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Date_rented_label.Location = new System.Drawing.Point(24, 142);
            this.Date_rented_label.Name = "Date_rented_label";
            this.Date_rented_label.Size = new System.Drawing.Size(63, 13);
            this.Date_rented_label.TabIndex = 12;
            this.Date_rented_label.Text = "Date rented";
            // 
            // Rental_features
            // 
            this.Rental_features.AutoSize = true;
            this.Rental_features.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Rental_features.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_features.Location = new System.Drawing.Point(100, 7);
            this.Rental_features.Name = "Rental_features";
            this.Rental_features.Size = new System.Drawing.Size(134, 20);
            this.Rental_features.TabIndex = 4;
            this.Rental_features.Text = "Rental features";
            // 
            // Movie_name_label
            // 
            this.Movie_name_label.AutoSize = true;
            this.Movie_name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Movie_name_label.Location = new System.Drawing.Point(24, 53);
            this.Movie_name_label.Name = "Movie_name_label";
            this.Movie_name_label.Size = new System.Drawing.Size(65, 13);
            this.Movie_name_label.TabIndex = 10;
            this.Movie_name_label.Text = "Movie name";
            // 
            // Customer_name_label
            // 
            this.Customer_name_label.AutoSize = true;
            this.Customer_name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Customer_name_label.Location = new System.Drawing.Point(24, 95);
            this.Customer_name_label.Name = "Customer_name_label";
            this.Customer_name_label.Size = new System.Drawing.Size(80, 13);
            this.Customer_name_label.TabIndex = 11;
            this.Customer_name_label.Text = "Customer name";
            this.Customer_name_label.Click += new System.EventHandler(this.label9_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelCustomer.Controls.Add(this.Update_customer_btn);
            this.panelCustomer.Controls.Add(this.Delete_customer_btn);
            this.panelCustomer.Controls.Add(this.Phone_text);
            this.panelCustomer.Controls.Add(this.Add_customer_btn);
            this.panelCustomer.Controls.Add(this.Address_text);
            this.panelCustomer.Controls.Add(this.Last_name_text);
            this.panelCustomer.Controls.Add(this.First_name_label);
            this.panelCustomer.Controls.Add(this.First_name_text);
            this.panelCustomer.Controls.Add(this.Phone_label);
            this.panelCustomer.Controls.Add(this.Last_name_label);
            this.panelCustomer.Controls.Add(this.Address_label);
            this.panelCustomer.Controls.Add(this.Customer_features);
            this.panelCustomer.Location = new System.Drawing.Point(441, 327);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(419, 294);
            this.panelCustomer.TabIndex = 3;
            // 
            // Update_customer_btn
            // 
            this.Update_customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Update_customer_btn.Location = new System.Drawing.Point(160, 256);
            this.Update_customer_btn.Name = "Update_customer_btn";
            this.Update_customer_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_customer_btn.TabIndex = 26;
            this.Update_customer_btn.Text = "Update";
            this.Update_customer_btn.UseVisualStyleBackColor = false;
            this.Update_customer_btn.Click += new System.EventHandler(this.Update_customer_btn_Click);
            // 
            // Delete_customer_btn
            // 
            this.Delete_customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete_customer_btn.Location = new System.Drawing.Point(275, 256);
            this.Delete_customer_btn.Name = "Delete_customer_btn";
            this.Delete_customer_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_customer_btn.TabIndex = 30;
            this.Delete_customer_btn.Text = "Delete";
            this.Delete_customer_btn.UseVisualStyleBackColor = false;
            this.Delete_customer_btn.Click += new System.EventHandler(this.Delete_customer_btn_Click);
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(250, 206);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(100, 20);
            this.Phone_text.TabIndex = 18;
            // 
            // Add_customer_btn
            // 
            this.Add_customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Add_customer_btn.Location = new System.Drawing.Point(46, 256);
            this.Add_customer_btn.Name = "Add_customer_btn";
            this.Add_customer_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_customer_btn.TabIndex = 29;
            this.Add_customer_btn.Text = "Add";
            this.Add_customer_btn.UseVisualStyleBackColor = false;
            this.Add_customer_btn.Click += new System.EventHandler(this.Add_customer_btn_Click);
            // 
            // Address_text
            // 
            this.Address_text.Location = new System.Drawing.Point(250, 160);
            this.Address_text.Name = "Address_text";
            this.Address_text.Size = new System.Drawing.Size(100, 20);
            this.Address_text.TabIndex = 17;
            this.Address_text.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // Last_name_text
            // 
            this.Last_name_text.Location = new System.Drawing.Point(250, 110);
            this.Last_name_text.Name = "Last_name_text";
            this.Last_name_text.Size = new System.Drawing.Size(100, 20);
            this.Last_name_text.TabIndex = 16;
            // 
            // First_name_label
            // 
            this.First_name_label.AutoSize = true;
            this.First_name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.First_name_label.Location = new System.Drawing.Point(28, 77);
            this.First_name_label.Name = "First_name_label";
            this.First_name_label.Size = new System.Drawing.Size(55, 13);
            this.First_name_label.TabIndex = 13;
            this.First_name_label.Text = "First name";
            // 
            // First_name_text
            // 
            this.First_name_text.Location = new System.Drawing.Point(250, 70);
            this.First_name_text.Name = "First_name_text";
            this.First_name_text.Size = new System.Drawing.Size(100, 20);
            this.First_name_text.TabIndex = 13;
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Phone_label.Location = new System.Drawing.Point(28, 213);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(38, 13);
            this.Phone_label.TabIndex = 4;
            this.Phone_label.Text = "Phone";
            // 
            // Last_name_label
            // 
            this.Last_name_label.AutoSize = true;
            this.Last_name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Last_name_label.Location = new System.Drawing.Point(28, 118);
            this.Last_name_label.Name = "Last_name_label";
            this.Last_name_label.Size = new System.Drawing.Size(56, 13);
            this.Last_name_label.TabIndex = 14;
            this.Last_name_label.Text = "Last name";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Address_label.Location = new System.Drawing.Point(28, 167);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(45, 13);
            this.Address_label.TabIndex = 15;
            this.Address_label.Text = "Address";
            // 
            // Customer_features
            // 
            this.Customer_features.AutoSize = true;
            this.Customer_features.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Customer_features.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_features.ForeColor = System.Drawing.Color.Black;
            this.Customer_features.Location = new System.Drawing.Point(143, 12);
            this.Customer_features.Name = "Customer_features";
            this.Customer_features.Size = new System.Drawing.Size(158, 20);
            this.Customer_features.TabIndex = 4;
            this.Customer_features.Text = "Customer features";
            // 
            // rentedOut_button
            // 
            this.rentedOut_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rentedOut_button.Location = new System.Drawing.Point(691, 647);
            this.rentedOut_button.Name = "rentedOut_button";
            this.rentedOut_button.Size = new System.Drawing.Size(75, 23);
            this.rentedOut_button.TabIndex = 31;
            this.rentedOut_button.Text = "Rented Out";
            this.rentedOut_button.UseVisualStyleBackColor = false;
            this.rentedOut_button.Click += new System.EventHandler(this.rentedOut_button_Click);
            // 
            // allRented_button
            // 
            this.allRented_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.allRented_button.Location = new System.Drawing.Point(472, 647);
            this.allRented_button.Name = "allRented_button";
            this.allRented_button.Size = new System.Drawing.Size(101, 23);
            this.allRented_button.TabIndex = 32;
            this.allRented_button.Text = "All Rented Movies";
            this.allRented_button.UseVisualStyleBackColor = false;
            this.allRented_button.Click += new System.EventHandler(this.allRented_button_Click);
            // 
            // Video_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(888, 682);
            this.Controls.Add(this.allRented_button);
            this.Controls.Add(this.rentedOut_button);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelRental);
            this.Controls.Add(this.panelMovie);
            this.Controls.Add(this.customertab);
            this.Name = "Video_Rental";
            this.Text = "Video_Rental ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customertab.ResumeLayout(false);
            this.customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_grid)).EndInit();
            this.movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movie_grid)).EndInit();
            this.rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rental_grid)).EndInit();
            this.tab_popularMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popuMovie_dgv)).EndInit();
            this.tab_popuCust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popuCust_dgv)).EndInit();
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            this.panelRental.ResumeLayout(false);
            this.panelRental.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl customertab;
        private System.Windows.Forms.TabPage customer;
        private System.Windows.Forms.TabPage movie;
        private System.Windows.Forms.TabPage rental;
        private System.Windows.Forms.DataGridView customer_grid;
        private System.Windows.Forms.DataGridView movie_grid;
        private System.Windows.Forms.DataGridView rental_grid;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Panel panelRental;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label Movie_features;
        private System.Windows.Forms.Label Rental_features;
        private System.Windows.Forms.Label Customer_features;
        private System.Windows.Forms.Label Date_rented_label;
        private System.Windows.Forms.Label Customer_name_label;
        private System.Windows.Forms.Label Movie_name_label;
        private System.Windows.Forms.Label Genre_label;
        private System.Windows.Forms.Label Plot_label;
        private System.Windows.Forms.Label Copies_label;
        private System.Windows.Forms.Label Rental_cost_label;
        private System.Windows.Forms.Label Year_label;
        private System.Windows.Forms.Label Tittle_label;
        private System.Windows.Forms.Label Rating_label;
        private System.Windows.Forms.Label Date_returned_label;
        private System.Windows.Forms.Label First_name_label;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.Label Last_name_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.TextBox First_name_text;
        private System.Windows.Forms.TextBox Customer_name_text;
        private System.Windows.Forms.TextBox Plot_text;
        private System.Windows.Forms.TextBox Rating_text;
        private System.Windows.Forms.TextBox Tittle_text;
        private System.Windows.Forms.TextBox Year_text;
        private System.Windows.Forms.TextBox Movie_name_text;
        private System.Windows.Forms.TextBox Genre_text;
        private System.Windows.Forms.TextBox Copies_text;
        private System.Windows.Forms.TextBox Rental_cost_text;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.TextBox Address_text;
        private System.Windows.Forms.TextBox Last_name_text;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Update_movie_btn;
        private System.Windows.Forms.Button Delete_movie_btn;
        private System.Windows.Forms.Button Add_movie_btn;
        private System.Windows.Forms.Button Return_Movie_renatl_btn;
        private System.Windows.Forms.Button Issue_Movie_rental_btn;
        private System.Windows.Forms.Button Update_customer_btn;
        private System.Windows.Forms.Button Delete_customer_btn;
        private System.Windows.Forms.Button Add_customer_btn;
        private System.Windows.Forms.DateTimePicker DateTime_returned_text;
        private System.Windows.Forms.DateTimePicker DateTime_rented_text;
        private System.Windows.Forms.TabPage tab_popularMovie;
        private System.Windows.Forms.DataGridView popuMovie_dgv;
        private System.Windows.Forms.TabPage tab_popuCust;
        private System.Windows.Forms.DataGridView popuCust_dgv;
        private System.Windows.Forms.Button rentedOut_button;
        private System.Windows.Forms.Button allRented_button;
    }
}

