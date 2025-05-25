const request = require('supertest');
const app = require('../app/app');

describe('GET /', () => {
  it('responds with Hello, DevOps World!', (done) => {
    request(app)
      .get('/')
      .expect(200)
      .expect('Hello, DevOps World!', done);
  });
});
