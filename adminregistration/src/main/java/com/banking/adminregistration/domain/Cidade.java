package com.banking.adminregistration.domain;

import javax.persistence.Id;
import javax.validation.constraints.NotEmpty;

public class Cidade {

    @Id
    public int cidadeId;

    public int countryId;

    public int estadoId;

    @NotEmpty
    private String nome;

    public int getCidadeId() {
        return cidadeId;
    }

    public int getCountryId() {
        return countryId;
    }

    public int getEstadoId() {
        return estadoId;
    }

    public String getNome() {
        return nome;
    }



    public void setCidadeId(int cidadeId) {
        this.cidadeId = cidadeId;
    }

    public void setCountryId(int countryId) {
        this.countryId = countryId;
    }

    public void setEstadoId(int estadoId) {
        this.estadoId = estadoId;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
}
