CREATE TABLE customers_cats(
   cat_id INT,
   cat_name VARCHAR(50) NOT NULL,
   cat_description TEXT,
   PRIMARY KEY(cat_id),
   UNIQUE(cat_name)
);

CREATE TABLE customers(
   customer_id INT,
   customer_name VARCHAR(100),
   customer_email VARCHAR(255) NOT NULL,
   cat_id INT NOT NULL,
   PRIMARY KEY(customer_id),
   UNIQUE(customer_name),
   UNIQUE(customer_email),
   FOREIGN KEY(cat_id) REFERENCES customers_cats(cat_id)
);

CREATE TABLE jobs(
   job_id INT,
   job_state CHAR(10) NOT NULL,
   job_title VARCHAR(100) NOT NULL,
   job_start DATETIME,
   job_end DATETIME,
   job_description TEXT,
   customer_id INT NOT NULL,
   PRIMARY KEY(job_id),
   FOREIGN KEY(customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE quotes(
   quote_id INT,
   quote_state CHAR(10) NOT NULL,
   quote_date DATE NOT NULL,
   quote_amount INT NOT NULL,
   quote_final_date DATE,
   quote_final_amount INT,
   job_id INT NOT NULL,
   PRIMARY KEY(quote_id),
   FOREIGN KEY(job_id) REFERENCES jobs(job_id)
);
