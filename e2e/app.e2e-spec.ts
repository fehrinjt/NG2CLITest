import { NG2CLITestPage } from './app.po';

describe('ng2-clitest App', function() {
  let page: NG2CLITestPage;

  beforeEach(() => {
    page = new NG2CLITestPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
