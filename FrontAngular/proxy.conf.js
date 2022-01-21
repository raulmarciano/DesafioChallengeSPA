const proxy = [
    {
      context: '/api',
      target: 'https://localhost:5001',
      secure: false,
      pathRewrite: {'^/api' : ''}
    }
  ];
  module.exports = proxy;