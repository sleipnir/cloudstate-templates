
package com.example;

import com.example.shoppingcart.Shoppingcart;
import io.cloudstate.javasupport.CloudState;

public class Main {

  public static void main(String... args) {
    new CloudState()
        .registerEventSourcedEntity(
            ShoppingCartEntity.class,
            Shoppingcart.getDescriptor().findServiceByName("ShoppingCart"))
        .start();
  }
}
        