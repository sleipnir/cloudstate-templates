
# ------------------------------------------------------------------------------
# Cargo Build Stage
# ------------------------------------------------------------------------------
#ARG BASE_IMAGE=ekidd/rust-musl-builder:latest
ARG BASE_IMAGE=ekidd/rust-musl-builder:nightly-2019-11-06

# Our first FROM statement declares the build environment.
FROM ${BASE_IMAGE} AS cargo-build

RUN sudo apt-get update && sudo apt-get install -y upx-ucl

# Add our source code.
ADD . ./

# Fix permissions on source code.
RUN sudo chown -R rust:rust /home/rust

# Build our application.
RUN cargo build --release

RUN /usr/bin/upx --brute /home/rust/src/target/x86_64-unknown-linux-musl/release/{application-name}

# Now, we need to build our _real_ Docker container, copying in `using-diesel`.
# ------------------------------------------------------------------------------
# Final Stage
# -------------------- ----------------------------------------------------------
FROM scratch
COPY --from=cargo-build /home/rust/src/target/x86_64-unknown-linux-musl/release/{application-name} \
    /usr/local/bin/

CMD ["/usr/local/bin/{application-name}"]
            
