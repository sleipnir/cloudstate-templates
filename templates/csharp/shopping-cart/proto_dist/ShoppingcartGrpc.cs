// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: shoppingcart/shoppingcart.proto
// </auto-generated>
// Original file comments:
// This is the public API offered by the shopping cart entity.
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Com.Example.Shoppingcart {
  public static partial class ShoppingCart
  {
    static readonly string __ServiceName = "com.example.shoppingcart.ShoppingCart";

    static readonly grpc::Marshaller<global::Com.Example.Shoppingcart.AddLineItem> __Marshaller_com_example_shoppingcart_AddLineItem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Shoppingcart.AddLineItem.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Shoppingcart.RemoveLineItem> __Marshaller_com_example_shoppingcart_RemoveLineItem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Shoppingcart.RemoveLineItem.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Shoppingcart.GetShoppingCart> __Marshaller_com_example_shoppingcart_GetShoppingCart = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Shoppingcart.GetShoppingCart.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Shoppingcart.Cart> __Marshaller_com_example_shoppingcart_Cart = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Shoppingcart.Cart.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.Example.Shoppingcart.AddLineItem, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddItem = new grpc::Method<global::Com.Example.Shoppingcart.AddLineItem, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddItem",
        __Marshaller_com_example_shoppingcart_AddLineItem,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Com.Example.Shoppingcart.RemoveLineItem, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveItem = new grpc::Method<global::Com.Example.Shoppingcart.RemoveLineItem, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveItem",
        __Marshaller_com_example_shoppingcart_RemoveLineItem,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Com.Example.Shoppingcart.GetShoppingCart, global::Com.Example.Shoppingcart.Cart> __Method_GetCart = new grpc::Method<global::Com.Example.Shoppingcart.GetShoppingCart, global::Com.Example.Shoppingcart.Cart>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCart",
        __Marshaller_com_example_shoppingcart_GetShoppingCart,
        __Marshaller_com_example_shoppingcart_Cart);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.Example.Shoppingcart.ShoppingcartReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ShoppingCart</summary>
    [grpc::BindServiceMethod(typeof(ShoppingCart), "BindService")]
    public abstract partial class ShoppingCartBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddItem(global::Com.Example.Shoppingcart.AddLineItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RemoveItem(global::Com.Example.Shoppingcart.RemoveLineItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Com.Example.Shoppingcart.Cart> GetCart(global::Com.Example.Shoppingcart.GetShoppingCart request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ShoppingCart</summary>
    public partial class ShoppingCartClient : grpc::ClientBase<ShoppingCartClient>
    {
      /// <summary>Creates a new client for ShoppingCart</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ShoppingCartClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ShoppingCart that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ShoppingCartClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ShoppingCartClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ShoppingCartClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddItem(global::Com.Example.Shoppingcart.AddLineItem request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddItem(global::Com.Example.Shoppingcart.AddLineItem request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddItem, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddItemAsync(global::Com.Example.Shoppingcart.AddLineItem request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddItemAsync(global::Com.Example.Shoppingcart.AddLineItem request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddItem, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveItem(global::Com.Example.Shoppingcart.RemoveLineItem request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveItem(global::Com.Example.Shoppingcart.RemoveLineItem request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveItem, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveItemAsync(global::Com.Example.Shoppingcart.RemoveLineItem request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveItemAsync(global::Com.Example.Shoppingcart.RemoveLineItem request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveItem, null, options, request);
      }
      public virtual global::Com.Example.Shoppingcart.Cart GetCart(global::Com.Example.Shoppingcart.GetShoppingCart request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCart(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.Example.Shoppingcart.Cart GetCart(global::Com.Example.Shoppingcart.GetShoppingCart request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCart, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Shoppingcart.Cart> GetCartAsync(global::Com.Example.Shoppingcart.GetShoppingCart request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCartAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Shoppingcart.Cart> GetCartAsync(global::Com.Example.Shoppingcart.GetShoppingCart request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCart, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ShoppingCartClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ShoppingCartClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ShoppingCartBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddItem, serviceImpl.AddItem)
          .AddMethod(__Method_RemoveItem, serviceImpl.RemoveItem)
          .AddMethod(__Method_GetCart, serviceImpl.GetCart).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ShoppingCartBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.Example.Shoppingcart.AddLineItem, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.AddItem));
      serviceBinder.AddMethod(__Method_RemoveItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.Example.Shoppingcart.RemoveLineItem, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.RemoveItem));
      serviceBinder.AddMethod(__Method_GetCart, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.Example.Shoppingcart.GetShoppingCart, global::Com.Example.Shoppingcart.Cart>(serviceImpl.GetCart));
    }

  }
}
#endregion
