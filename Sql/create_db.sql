DROP TABLE IF EXISTS listing;
CREATE TABLE listing (
  ebay_id CHAR(100) NOT NULL primary key,
  asin CHAR(100) DEFAULT NULL,
  upc CHAR(100) DEFAULT NULL,
  quantity INT(11) DEFAULT NULL,
  purchases INT(11) DEFAULT NULL,
  price DOUBLE DEFAULT NULL,
  start_date DATE DEFAULT NULL,
  end_date DATE DEFAULT NULL,
  title CHAR(100) DEFAULT NULL,
  category CHAR(100) DEFAULT NULL,
  pic_url TEXT,
);

DROP TABLE IF EXISTS competative_item;
CREATE TABLE competative_item
(
	ebay_id VARCHAR(30) PRIMARY KEY,
    upc VARCHAR(30),
	title VARCHAR(200),
	category VARCHAR(200),
	url VARCHAR(2000),
	price DOUBLE,
    hit_count LONG
);

DROP TABLE IF EXISTS competative_item_transaction;
CREATE TABLE competative_item_transaction
(
	ebay_item_id VARCHAR(30),
    transaction_id VARCHAR(30) PRIMARY KEY,
    transaction_time_utc DATE,
    quantity INTEGER,
    price DOUBLE,
    FOREIGN KEY (ebay_item_id) REFERENCES competative_item(ebay_id) ON DELETE SET NULL
);
