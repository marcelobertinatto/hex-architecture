package db

import (
	application "command-line-arguments/home/mbertinatto/projects/FullCycle/Hexa-Architecture/application/product.go"
	"database/sql"

	_ "github.com/mattn/go-sqlite3"
)

type ProductDb struct {
	db *sql.DB
}

func (p *ProductDb) Get(id string) (application.ProductInterface, error) {
	var product application.Product

	stmt, err := p.db.Prepare("seelct id, name, price, status from products where id=?")
	if err != nil {
		return nil, err
	}

	err = stmt.QueryRow(id).Scan(&product.id, &product.name, &product.Price, &product.Status)
	if err != nil {
		return nil, err
	}

	return &product, nil
}
