FROM node:8.15

# Copy and install deps. This is done as a separate step as an optimization, so changes to the programs files
# don't require the npm install to be redone
RUN mkdir -p /opt/samples/js-shopping-cart
RUN mkdir -p /opt/protocols/example
COPY node-support /opt/node-support
COPY samples/js-shopping-cart/package.json /opt/samples/js-shopping-cart/
RUN cd /opt/node-support && npm install && cd /opt/samples/js-shopping-cart && npm install

# Now copy the entire app
COPY samples/js-shopping-cart /opt/samples/js-shopping-cart
COPY protocols/example /opt/protocols/example
WORKDIR /opt/samples/js-shopping-cart
RUN npm run prestart

# run
EXPOSE 8080
CMD ["npm", "run", "start-no-prestart"]
