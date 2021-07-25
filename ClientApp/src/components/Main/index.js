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
  const [estimate, setEstimate] = useState(null)
  const [estimateVisible, toggleEstimateVisibility] = useState(false)

  const formCallback = useCallback(formSelection => {
    selectForm(formSelection)
  }, [])

  const estimateCallback = useCallback(estimate => {
    setEstimate(estimate)
  }, [])

  const estimateVisibilityCallback = useCallback(estimateVisible => {
    toggleEstimateVisibility(estimateVisible)
  }, [])

  console.log(formSelection)
  console.log(estimate)
  console.log(estimateVisible)

  let visibleState = null

  if (formSelection === 0) {
    visibleState = <Electricity
      formCallback={formCallback}
      estimateCallback={estimateCallback}
      estimateVisibilityCallback={estimateVisibilityCallback}
    />
  } else if (formSelection === 1) {
    visibleState = <Flight />
  } else if (formSelection === 2) {
    visibleState = <Shipping />
  } else if (formSelection === 3) {
    visibleState = <Vehicle />
  } else if (formSelection === 4) {
    visibleState = <FuelCombustion />
  } else if (
    formSelection === null &&
    estimate != null &&
    estimateVisible === true) {
    visibleState = <Estimate />
  }

  return (
    <>
      <Header />
      <About />
      <Nav mainCallback={formCallback} />

      <div>
        {visibleState}
      </div>

      <Footer />
    </>
  )
}
