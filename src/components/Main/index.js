/* eslint-disable jsx-a11y/click-events-have-key-events */
import { useCallback, useState } from 'react'
import Header from '../Header'
import About from './About'
import Nav from './Nav'
import Estimate from './Estimate'
import Electricity from './Electricity'
import Flight from './Flight'
import Shipping from './Shipping'
import Vehicle from './Vehicle'
import FuelCombustion from './FuelCombustion'
import Footer from '../Footer'

export default () => {
  const [formSelection, selectForm] = useState(null)

  const formCallback = useCallback(formSelection => {
    selectForm(formSelection)
  }, [])

  console.log(formSelection)

  let visibleState = null

  if (formSelection === 0) {
    visibleState = <Electricity />
  } else if (formSelection === 1) {
    visibleState = <Flight />
  } else if (formSelection === 2) {
    visibleState = <Shipping />
  } else if (formSelection === 3) {
    visibleState = <Vehicle />
  } else if (formSelection === 4) {
    visibleState = <FuelCombustion />
  }

  return (
    <>
      <Header />
      <About />
      <Nav mainCallback={formCallback} />

      <div>
        {visibleState}
      </div>

      <Estimate />
      <Footer />
    </>
  )
}
