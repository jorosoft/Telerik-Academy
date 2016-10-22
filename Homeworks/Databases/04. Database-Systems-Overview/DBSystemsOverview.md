# Database Systems Overview Homework #

1. What database models do you know?

	**Answer:**

		- Hierarchical model
		- Network model
		- Relational model
		- Object model
		- Document model

2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

	**Answer:**
		
		- Provides data to be stored in tables
		- Persists data in the form of rows and columns
		- Tables are created and managed using SQL language
		- Provides fully management operations at tables structure,
		  connections and entire data like creating, reading, altering, deleting

3. Define what is "table" in database terms.

	**Answer:**

		Database table is structure for keeping data in rows and columns. 
		All rows have same structure. Every column have name and type of stored data.

4. Explain the difference between a primary and a foreign key.

	**Answer:**

		Primary key is unique identifier for every record (row) of database.
		Foreign key usually is not unique and is used for connection with 
		another table in database by linking her primary key.

5. Explain the different kinds of relationships between tables in relational databases.

	**Answer:**
 
		- "One to one"
			* A single record in a table corresponds to a single record 
			  in the other table (inheritance between tables)
		- "One to Many" and "Many to One"
			* A single record in the first table has many corresponding 
			  records in the second table (used very often)
		- "Many to Many"
			* Records in the first table have many corresponding 
			  records in the second one (used through additional table) 

6. When is a certain database schema normalized?

	**Answer:**

		Normalization is part of successful database design. 
		Without normalization, database systems can be inaccurate, slow, and inefficient, 
		and they might not produce the data you expect. 

7. What are the advantages of normalized databases?

	**Answer:**

		- Data integrity (because there is no redundant, neglected data)
		- Optimized queries (because normalized tables produce rapid, efficient joins)
		- Faster index creation and sorting (because the tables have fewer columns)
		- Faster UPDATE performance (because there are fewer indexes per table)
		- Improved concurrency resolution (because table locks will affect less data)


8. What are database integrity constraints and when are they used?

	**Answer:**

		Integrity constraints provide a way of ensuring that changes made to the
		database by authorized users do not result in a loss of data consistency. 
		We saw a form of integrity constraint with E-R models, key declarations,
		stipulation that certain attributes form a candidate key for the entity set.

9. Point out the pros and cons of using indexes in a database.

	**Answer:**

		* pros:
			- You will get a lot faster results when select data if you have 
			  index at searched data column.
		* cons:
			- If indexes are used, writing to table (for example inserting rows) is
			  slower, because in addition to just writing the data, MySQL needs to
			  handle the index file also.	

10. What's the main purpose of the SQL language?

	**Answer:**

		SQL is short for Structured Query Language. 
		It is a standard programming language used in the management of data stored 
		in a 	relational database management system.
		SQL allows users to access data stored in a relational database management system. 
		Users can create and delete databases, as well as set permissions on 
		database tables, views and procedures. 
		It also allows users to manipulate the data within a database.

11. What are transactions used for?

	**Answer:**

		A transaction is a unit of work that you want to treat as "a whole". 
		It has to either happen in full, or not at all.

12. Give an example.

	**Answer:**

		A classical example is transferring money from one bank account to another. 
		To do that you have to first withdraw the amount from the source account, 
		and then deposit it to the destination account. 
		The operation has to succeed in full. 
		If you stop halfway, the money will be lost

13. What is a NoSQL database?

	**Answer:**

		NoSQL (non-relational) databases uses document-based model.
		They have great performance and scalability and 
		highly optimized for append / retrieve.
		

14. Explain the classical non-relational data models.

	**Answer:**

		- Document Databases
		- Key-Value Stores
		- BigTable-style Databases

15. Give few examples of NoSQL databases and their pros and cons.

	**Answer:**

		- MongoDB
			* pros: 
				- Schema-less. If you have a flexible schema, this is ideal for a document store 
				  like MongoDB. This is difficult to implement in a performant manner in RDBMS
				- Ease of scale-out. Scale reads by using replica sets. Scale writes by using 
				  sharding (auto balancing). Just fire up another machine and away you go. 
				  Adding more machines = adding more RAM over which to distribute your working set.
				- Cost. Depends on which RDBMS of course, but MongoDB is free and can run on Linux, 
				  ideal for running on cheaper commodity kit.
				- You can choose what level of consistency you want depending on the value of the data 
				  (e.g. faster performance = fire and forget inserts to MongoDB, 
				  slower performance = wait til insert has been replicated to multiple nodes before returning)
				
			* cons: 
				- Data size in MongoDB is typically higher due to e.g. each document has field names stored it
				- Less flexibity with querying (e.g. no JOINs)
				- no support for transactions - certain atomic operations are supported, at a single document level
				- At the moment Map/Reduce (e.g. to do aggregations/data analysis) is OK, but not blisteringly fast. 
				  So if that's required, something like Hadoop may need to be added into the mix
				- Less up to date information available/fast evolving product
			
		- Redis 
			* pros: 
				- Stores data in a variety of formats: list, array, sets and sorted sets
				- Pipelining!  Multiple commands at once
				- Blocking reads -- will sit and wait until another process writes data to 
				  the cache
				- Mass insertion of data to prime a cache
				- Does pub/sub... if you want to do pub/sub through your cache
				- Partitions data across multiple redis instances
				- Can back data to disk
				
			* cons:
				- Super complex to configure -- requires consideration of data size to configure well
				- SENTINEL, the automated failover which promotes a slave to master, is perpetually on the redis 
				  unstable branch
				- Master-slave architecture means if the master wipes out, and SENTINEL doesn't work, 
				  the system is sad
				- Lots o' server administration for monitoring and partitioning and balancing... 
				
		- Cassandra
			* pros: 
				- Cassandra is solving the problem of distributed and scalable systems, 
				  and it’s built to cope with data management challenges of modern business.
				- Cassandra is decentralized system - There is no single point of failure, 
				  if minimum required setup for cluster is present - every node in the cluster has 
				  the same role, and every node can service any request. Replication strategies can be configured. 
				  It is possible to add new nodes to server cluster very easy. Also, if one node fails, data can be 
				  retrieved from some of the other nodes (redundancy can be tuned). It is especially suitable for 
				  multiple data-center deployment, redundancy, failover and disaster recovery, with possibility of 
				  replication across multiple data centers.
				
			* cons:
				- There is no referential integrity - there is no concept of JOIN connections in Cassandra
				- Querying options for retrieving data are very limited
				- Sorting of data is a design decision; it can be done through one of predefined ways; data can be 
				  retrieved back in same order; that’s all - there is no things like ORDER BY, GROUP BY
				- Denormalization is good; you want to normalize your data and to have redundancy 
				  (big no-no according to Codd) - data is stored in a way that it will be retrieved
				- Different database design; in RDBMS we think about data modeling first, and after that we create 
				  queries; here, we think first about most common queries, and after that, data is being modeled 
				  around those queries.