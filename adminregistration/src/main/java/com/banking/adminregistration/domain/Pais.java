package com.banking.adminregistration.domain;

import javax.persistence.Id;
import javax.validation.constraints.NotEmpty;

public class Pais {

    @Id
    public int paisId;

    @NotEmpty
    private String primeiroNome;

    @NotEmpty
    private String nomeMeio;

    @NotEmpty
    private String sobreNome;
}
