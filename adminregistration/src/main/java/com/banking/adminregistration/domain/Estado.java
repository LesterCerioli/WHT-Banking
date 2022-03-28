package com.banking.adminregistration.domain;

import javax.validation.constraints.NotEmpty;
import javax.persistence.Id;

public class Estado {

    @Id
    public int estadoId;

    @NotEmpty
    private String nome;
}
