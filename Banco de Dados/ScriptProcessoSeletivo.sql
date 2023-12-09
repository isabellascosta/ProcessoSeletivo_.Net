create database DB_JogoAdivinhacao;

 CREATE TABLE historico (
	id INT PRIMARY KEY auto_increment,
    nome VARCHAR(45),
    numerotentativas INT(10),
    datajogada Datetime,
    resultado varchar(15)
);
DELIMITER //
CREATE PROCEDURE InsereHistorico(
    OUT p_id INT,
    IN p_nome VARCHAR(45),
    IN p_numerotentativas INT(10),
    IN p_datajogada DATETIME,
    IN p_resultado VARCHAR(15)
)
BEGIN
    INSERT INTO historico (id, nome, numerotentativas, datajogada, resultado)
    VALUES (0, p_nome, p_numerotentativas, p_datajogada,p_resultado);
     set p_id = last_insert_id();
END//
DELIMITER ;


 select * from historico;

