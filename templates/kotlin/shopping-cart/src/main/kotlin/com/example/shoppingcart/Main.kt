package com.example.shoppingcart

import ShoppingCartEntity
import com.example.shoppingcart.persistence.Domain
import io.cloudstate.kotlinsupport.cloudstate

fun main() {

    cloudstate {

        host = "0.0.0.0"
        port = 8080
        loglevel = "DEBUG"

        registerEventSourcedEntity {
            entityService = ShoppingCartEntity::class.java

            descriptor = Shoppingcart.getDescriptor().findServiceByName("ShoppingCart")
            additionalDescriptors = arrayOf( Domain.getDescriptor() )

        }
    }.start()
            .toCompletableFuture()
            .get()
}