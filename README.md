# WebApiPKGrpcOverHttp2
WebApi 基于 HTTP2协议 PK Grpc 基于HTTP2协议 PK WebApi基于HTTP1.1协议

# 性能测试

## 机器环境

## 测试结果
# **Grpc over http2 PK WebApi over http2 PK WebApi over http1.1**

- 1000 次密集异步压力测试  1千

```
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
1
GRPC takes:200毫秒,     0.2ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
2
WebApi2 takes:1155毫秒  1.16ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
3
WebApi1 takes:172毫秒   0.17ms/p
```

- 10000 次密集异步压力测试 1万

```
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
1
GRPC takes:1429毫秒     0.14ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
2
WebApi2 takes:2241毫秒  0.22ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
3
WebApi1 takes:1434毫秒  0.14ms/p
```

- 100000 次密集异步压力测试 10万

```
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
1
GRPC takes:15088毫秒    0.15ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
2
WebApi2 takes:14095毫秒 0.14ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
3
WebApi1 takes:14548毫秒 0.15ms/p

```

- 1000000 次密集异步压力测试 100万

```
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
1
GRPC takes:147439毫秒    0.15ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
2
WebApi2 takes:122421毫秒 0.12ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
3
WebApi1 takes:141463毫秒 0.14ms/p
```

- 5000000 次密集异步压力测试 500万

```
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
1
GRPC takes:713348毫秒    0.14ms/p
1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test
2
WebApi2 takes:641404毫秒 0.12ms/p
3
WebApi1 takes:706381毫秒 0.14ms/p
```


## 分析
![每次请求所花费的时间](/uploads/dvc/images/m_deab8db53eed548e8cb158dd034784e5_r.png "每次请求所花费的时间")，单位ms

![请求所花费的总时间](/uploads/dvc/images/m_deab8db53eed548e8cb158dd034784e5_r.png "每次请求所花费的时间")，单位ms
