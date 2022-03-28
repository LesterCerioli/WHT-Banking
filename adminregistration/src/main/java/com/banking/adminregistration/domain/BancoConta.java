package com.banking.adminregistration.domain;

import javax.persistence.Id;
import javax.validation.constraints.NotEmpty;

public class BancoConta {

    @Id
    public int bancoId;

    @NotEmpty
    public String nome;
}
