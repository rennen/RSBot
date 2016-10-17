
drop table if exists listing;
create table listing
(
	ebay_id CHAR(100) PRIMARY KEY,
    asin CHAR(100),
    upc ChAR(100),
    quantity INT,
    purchases INT,
    price double,
    start_date DATE,
    end_date DATE,
    title CHAR(100),
    category CHAR(100),
    pic_url TEXT
);

drop table if exists listing_trans_log;
create table listing_trans_log
(
	ebay_id CHAR(100) PRIMARY KEY,
    timestamp DATE,
    collage_added BOOL
);

create or replace view v_listings_to_transform as
select ebay_id, pic_url
from listing
where length(pic_url) > 0 AND ebay_id not in (select ebay_id from listing_trans_log);
