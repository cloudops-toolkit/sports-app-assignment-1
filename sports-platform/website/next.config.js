module.exports = {
  output: 'export',
  async rewrites() {
    return [
      {
        source: '/api/:path*',
        destination: `http://sports-platform-alb-54461425.us-east-1.elb.amazonaws.com/api/:path*`
        // destination: `${process.env.NEXT_PUBLIC_API_URL}/:path*`
      }
    ]
  }
}