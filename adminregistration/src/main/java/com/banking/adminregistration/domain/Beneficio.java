package com.banking.adminregistration.domain;

import javax.persistence.Id;

public class Beneficio {


    @Id
    public int Id;

    private int type;

    private String descricao;

    private double value;

    public int getId() {
        return Id;
    }

    public int getType() {
        return type;
    }

    public String getDescricao() {
        return descricao;
    }

    public double getValue() {
        return value;
    }

    public void setId(int id) {
        Id = id;
    }

    public void setType(int type) {
        this.type = type;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public void setValue(double value) {
        this.value = value;
    }
}
