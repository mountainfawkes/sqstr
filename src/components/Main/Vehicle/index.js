import yugos from '../../../Data/Yugos'

const vehicleEstimateForm = () => {
  function handleVehicleInput(event) {
    event.preventDefault()
    console.log({
      type: event.target.type.value,
      distance_unit: event.target.distance_unit.value,
      distance_value: event.target.distance_value.value,
      vehicle_model_id: event.target.vehicle_model_id,
    })
  }

  return (
    <>
      <h3>This is the vehicle travel form.</h3>
      <form onSubmit={handleVehicleInput}>
        <input type='hidden' name='type' value='vehicle' />
        <label htmlFor='distance_unit'>Unit of distance:
          <select name='distance_unit'>
            <option value='mi'>Miles</option>
            <option value='km'>Kilometers</option>
          </select>
        </label>
        <label htmlFor='distance_value'>Distance traveled:
          <input type='number' step='0.1' min='0' name='distance_value' />
        </label>
        <label htmlFor='vehicle_model_id'>Vehicle make and model:
          <select name='vehicle_model_id'>
            {yugos.map(yugo =>
              <option value={yugo.id}>
                {
              yugo.attributes.year
              } {
              yugo.attributes.vehicle_make
              } {
              yugo.attributes.name
              }
              </option>)}
          </select>
        </label>
        <button type='submit'>Estimate</button>
      </form>
    </>
  )
}

export default vehicleEstimateForm
