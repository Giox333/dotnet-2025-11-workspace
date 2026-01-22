import Footer from "./footer";
import Intro from "./intro";
import MainContent from "./main_content";
import NavBar from "./navbar";

export default function Home() {
  let example = "Rob";

  let myVet = [1, 2, 3, 4, 5];
  //const raddoppia =(a: number[]) =>
  const saluta = () => "Ciao Mondo";

  //const timestamp =()
  const data = () => Date();

  return (
    <>
      <NavBar></NavBar>
      <Intro></Intro>
      <MainContent></MainContent>
      <Footer></Footer>
    </>
  );
}
