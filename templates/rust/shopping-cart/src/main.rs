
extern crate log;
extern crate log4rs;
extern crate cloudstate;

use std::env;
use log::{info};
use cloudstate::serveless::{CloudState, EntityService};

fn main() {

    // CloudState depends of log4rs to print messages
    log4rs::init_file(env::var("LOG_CONFIG_FILE_PATH").unwrap(), Default::default()).unwrap();
    info!("Starting CloudState Server...");

    let service = EntityService::new()
        .persistence_id("shopping-cart".to_string())
        .protos(vec!["shoppingcart/shoppingcart.proto".to_string(), "shoppingcart/persistence/domain.proto".to_string()])
        .snapshot(1)
        .event_sourced();

    CloudState::new()
        .register_entity_service(
            String::from("com.example.shoppingcart.ShoppingCart"),
            service)
        .start();
}
        
