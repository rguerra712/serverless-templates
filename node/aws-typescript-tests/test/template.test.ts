describe('class example', () => {
  class Foo {
    bar = (): string => {
      return 'foo';
    };
  }

  it('Example to mock a class', () => {
    const mockHandler = jest.fn<Foo>();
    // If not a class, use jest.mock('<function>'),
    // then mock the function.prototype
    mockHandler.mockImplementation(
        () => ({bar: jest.fn<string>().mockReturnValue('bar')}));
    const handlerMock = new mockHandler();
    const bar = handlerMock.bar();
    expect(bar).toBe('bar');
  });
});
