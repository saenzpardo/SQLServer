USE AP;

CREATE LOGIN AAaron WITH PASSWORD = 'AAar99999',
    DEFAULT_DATABASE = AP;

CREATE USER AAaron FOR LOGIN AAaron;

ALTER ROLE PaymentEntry ADD MEMBER AAaron;