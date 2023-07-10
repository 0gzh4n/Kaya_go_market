
DELIMITER $$
CREATE procedure kaya_MusteriEkle (
id			varchar(64) ,
ad			varchar(64) ,
soy			varchar(64) ,
tel			varchar(64) ,
mail		varchar(64) ,
adr			varchar(64) 
)
BEGIN
	INSERT INTO kaya_musteriler
    VALUES	(id, ad, soy, tel, mail, adr);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kaya_MusterilerHepsi ()
BEGIN
    SELECT 
        musteri_id      as ID,
        musteri_ad      as Adı,
        musteri_soyad   as Soyadı,
        musteri_tel     as Telefon, 
        musteri_mail    as Mail,
        musteri_adres   as Adres
    FROM kaya_musteriler;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE kaya_MusteriBul (
    filtre  varchar(32) 
)
BEGIN
    SELECT 
        musteri_id      as ID,
        musteri_ad      as Adı,
        musteri_soyad   as Soyadı,
        musteri_tel     as Telefon, 
        musteri_mail    as Mail,
        musteri_adres   as Adres
    FROM kaya_musteriler

    WHERE 
        musteri_ad      LIKE  CONCAT('%',filtre,'%') OR
        musteri_soyad   LIKE  CONCAT('%',filtre,'%') OR
        musteri_tel     LIKE  CONCAT('%',filtre,'%') OR
        musteri_mail    LIKE  CONCAT('%',filtre,'%') OR
        musteri_adres   LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE kaya_MusteriGuncelle (
    id      varchar(64) ,
    ad      varchar(64) ,
    soy     varchar(64) ,
    tel     varchar(25) ,
    mail    varchar(250),
    adr     varchar(250)
)
BEGIN
    UPDATE kaya_musteriler
    SET 
        musteri_ad      = ad,
        musteri_soyad   = soy,
        musteri_tel     = tel,
        musteri_mail    = mail,
        musteri_adres   = adr
    WHERE 
        musteri_id      = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kaya_MusteriSil (
    id      varchar(64) 
)
BEGIN
    DELETE FROM kaya_musteriler
    WHERE   musteri_id  = id;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE kaya_UrunEkle (
    id          varchar(64)  ,
    ad          varchar(250) ,
    kategori    varchar(250) ,
    fiyat       float        ,
    stok        float        ,
    birim       varchar(16)  ,
    detay       varchar(250) 
)
BEGIN
    INSERT INTO kaya_urunler
    VALUES  (id, ad, kategori, fiyat, stok, birim, detay);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kaya_UrunlerHepsi ()
BEGIN
	SELECT
		urun_id		as ID,
        urun_ad		as 'Ürün Ad',
        urun_kategori as Kategori,
        urun_fiyat	as	Fiyat,
        urun_stok	as	'Stok Miktarı',
        urun_birim	as	'Birim Fiyat',
        urun_detay	as	'Detay'
	FROM kaya_urunler;
   END $$
DELIMITER ;
        
        
    SELECT * FROM kaya_urunler;
END $$
DELIMITER ;
