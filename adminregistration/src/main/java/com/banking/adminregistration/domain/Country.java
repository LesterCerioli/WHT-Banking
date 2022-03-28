package com.banking.adminregistration.domain;

import javax.persistence.Id;
import javax.validation.constraints.NotEmpty;

public class Country {

    @Id
    public int countryId;

    @NotEmpty
    private String nome;
}
