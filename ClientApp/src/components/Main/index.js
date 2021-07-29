import '../../App.css'

/* eslint-disable jsx-a11y/click-events-have-key-events */
import { useCallback, useState } from 'react'
import Nav from './Nav'
import Estimate from './Estimate'
import Electricity from './Electricity'
import Flight from './Flight'
import Shipping from './Shipping'
import Vehicle from './Vehicle'
import FuelCombustion from './FuelCombustion'
import Instructions from './Instructions'

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
      key='electricity'
    />
  } else if (formSelection === 1) {
    visibleState = <Flight
      formCallback={formCallback}
      estimateCallback={estimateCallback}
      estimateVisibilityCallback={estimateVisibilityCallback}
      key='flight'
    />
  } else if (formSelection === 2) {
    visibleState = <Shipping
      formCallback={formCallback}
      estimateCallback={estimateCallback}
      estimateVisibilityCallback={estimateVisibilityCallback}
      key='shipping'
    />
  } else if (formSelection === 3) {
    visibleState = <Vehicle
      formCallback={formCallback}
      estimateCallback={estimateCallback}
      estimateVisibilityCallback={estimateVisibilityCallback}
      key='vehicle'
    />
  } else if (formSelection === 4) {
    visibleState = <FuelCombustion
      formCallback={formCallback}
      estimateCallback={estimateCallback}
      estimateVisibilityCallback={estimateVisibilityCallback}
      key='fuel-combustion'
    />
  } else if (
    formSelection === null &&
    estimate != null &&
    estimateVisible === true) {
    visibleState = <Estimate
      estimate={estimate}
      formCallback={formCallback}
      estimateCallback={estimateCallback}
      estimateVisibilityCallback={estimateVisibilityCallback}
      key='estimate'
    />
  } else { visibleState = <Instructions /> }

  return (
    <>
      <div style={{
        display: `flex`,
        flexFlow: `column wrap`,
        zIndex: `100`,
        marginTop: `125px`,
      }}
      >
        <Nav mainCallback={formCallback} />

        {visibleState}
      </div>

    </>
  )
}
