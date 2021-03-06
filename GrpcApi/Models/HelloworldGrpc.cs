// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: helloworld.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Helloworld {
  public static partial class helloWorldService
  {
    static readonly string __ServiceName = "helloworld.helloWorldService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Helloworld.sayHelloRequest> __Marshaller_helloworld_sayHelloRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Helloworld.sayHelloRequest.Parser));
    static readonly grpc::Marshaller<global::Helloworld.sayHelloResponse> __Marshaller_helloworld_sayHelloResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Helloworld.sayHelloResponse.Parser));

    static readonly grpc::Method<global::Helloworld.sayHelloRequest, global::Helloworld.sayHelloResponse> __Method_person = new grpc::Method<global::Helloworld.sayHelloRequest, global::Helloworld.sayHelloResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "person",
        __Marshaller_helloworld_sayHelloRequest,
        __Marshaller_helloworld_sayHelloResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Helloworld.HelloworldReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of helloWorldService</summary>
    [grpc::BindServiceMethod(typeof(helloWorldService), "BindService")]
    public abstract partial class helloWorldServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Helloworld.sayHelloResponse> person(global::Helloworld.sayHelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for helloWorldService</summary>
    public partial class helloWorldServiceClient : grpc::ClientBase<helloWorldServiceClient>
    {
      /// <summary>Creates a new client for helloWorldService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public helloWorldServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for helloWorldService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public helloWorldServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected helloWorldServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected helloWorldServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Helloworld.sayHelloResponse person(global::Helloworld.sayHelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return person(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Helloworld.sayHelloResponse person(global::Helloworld.sayHelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_person, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Helloworld.sayHelloResponse> personAsync(global::Helloworld.sayHelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return personAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Helloworld.sayHelloResponse> personAsync(global::Helloworld.sayHelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_person, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override helloWorldServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new helloWorldServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(helloWorldServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_person, serviceImpl.person).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, helloWorldServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_person, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Helloworld.sayHelloRequest, global::Helloworld.sayHelloResponse>(serviceImpl.person));
    }

  }
}
#endregion
