package com.banking.adminregistration.domain;

import javax.persistence.Id;
import javax.validation.constraints.NotEmpty;

public class Banco {


    @Id
    public int bancoId;

    @NotEmpty
    private String agencia;

    @NotEmpty
    private String agenciaDigito;

    @NotEmpty
    private String conta;

    @NotEmpty
    private String contaDigito;

    public int getBancoId() {
        return bancoId;
    }

    public String getAgencia() {
        return agencia;
    }

    public String getAgenciaDigito() {
        return agenciaDigito;
    }

    public String getConta() {
        return conta;
    }

    public String getContaDigito() {
        return contaDigito;
    }

    public void setBancoId(int bancoId) {
        this.bancoId = bancoId;
    }

    public void setAgencia(String agencia) {
        this.agencia = agencia;
    }

    public void setAgenciaDigito(String agenciaDigito) {
        this.agenciaDigito = agenciaDigito;
    }

    public void setConta(String conta) {
        this.conta = conta;
    }

    public void setContaDigito(String contaDigito) {
        this.contaDigito = contaDigito;
    }
}
